using CQRS.AspNetUI.Services;
using CQRS.AspNetUI.Services.Interfaces;
using CQRS.Contract.Share.DTO;
using CQRS.Contract.Share.Models;
using CQRS.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections;

namespace CQRS.AspNetUI.Controllers
{
    public class ProxyController : Controller
    {
        private readonly IProxyClientService _proxyClientService;
        private readonly IFileService _fileService;

        public ProxyController(IProxyClientService proxyClientService, IFileService fileService)
        {
            _proxyClientService = proxyClientService;
            _fileService = fileService;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<GetProxyDto> proxyResponse = await _proxyClientService.GetProxyAsync();
            List<GetProxyDto> proxies = new List<GetProxyDto>();
            proxies.AddRange(proxyResponse);
            //if (TempData["proxyDtos"] != null)
            //{
            //    var proxyDtos = JsonConvert.DeserializeObject<List<GetProxyDto>>(TempData["proxyDtos"].ToString());
            //    if (proxyDtos != null && proxyDtos.Any())
            //    {
            //        proxies.AddRange(proxyDtos);
            //    }
            //}
            
            return View(proxies);
        }

        public async Task<IActionResult> Details(string id)
        {
            var proxy = await _proxyClientService.GetProxyByIdAsync(id);
            if (proxy == null) return NotFound();

            return View(proxy);
        }

        //[HttpPost]
        public async Task<ActionResult> UploadProxy(IFormCollection collection)
        {
            string filePath = Path.Combine("Data", "proxies.txt"); // Assuming 'Data' folder is in the same directory as executable
            List<GetProxyDto> proxyLsit = await _fileService.ReadProxies(filePath);


            var proxiesChecked = await _proxyClientService.IsProxyWorking(proxyLsit);
            await _proxyClientService.UpdateProxiesAsync(proxiesChecked);
            //TempData["proxyDtos"] = JsonConvert.SerializeObject(proxiesChecked);


            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProxyDto proxy)
        {
            if (ModelState.IsValid)
            {
                await _proxyClientService.CreateProxyAsync(proxy);
                return RedirectToAction(nameof(Index));
            }

            return View(proxy);
        }

        public async Task<IActionResult> Edit(string id)
        {
            var proxy = await _proxyClientService.GetProxyByIdAsync(id);
            if (proxy == null) return NotFound();

            return View(proxy);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdateProxyDto proxy)
        {
            if (ModelState.IsValid)
            {
                await _proxyClientService.UpdateProxyAsync(proxy);
                return RedirectToAction(nameof(Index));
            }

            return View(proxy);
        }

        public async Task<IActionResult> Delete(string id)
        {
            var proxy = await _proxyClientService.GetProxyByIdAsync(id);
            if (proxy == null) return NotFound();

            return View(proxy);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            await _proxyClientService.DeleteProxyAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
