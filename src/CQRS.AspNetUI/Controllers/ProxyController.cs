using CQRS.AspNetUI.Services.Interfaces;
using CQRS.Contract.Share.DTO;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.AspNetUI.Controllers
{
    public class ProxyController : Controller
    {
        private readonly IProxyService _proxyService;

        public ProxyController(IProxyService proxyService)
        {
            _proxyService = proxyService;
        }

        public async Task<IActionResult> Index()
        {
            var proxy = await _proxyService.GetProxyAsync();
            return View(proxy);
        }

        public async Task<IActionResult> Details(string id)
        {
            var proxy = await _proxyService.GetProxyByIdAsync(id);
            if (proxy == null) return NotFound();

            return View(proxy);
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
                await _proxyService.CreateProxyAsync(proxy);
                return RedirectToAction(nameof(Index));
            }

            return View(proxy);
        }

        public async Task<IActionResult> Edit(string id)
        {
            var proxy = await _proxyService.GetProxyByIdAsync(id);
            if (proxy == null) return NotFound();

            return View(proxy);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdateProxyDto proxy)
        {
            if (ModelState.IsValid)
            {
                await _proxyService.UpdateProxyAsync(proxy);
                return RedirectToAction(nameof(Index));
            }

            return View(proxy);
        }

        public async Task<IActionResult> Delete(string id)
        {
            var proxy = await _proxyService.GetProxyByIdAsync(id);
            if (proxy == null) return NotFound();

            return View(proxy);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            await _proxyService.DeleteProxyAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
