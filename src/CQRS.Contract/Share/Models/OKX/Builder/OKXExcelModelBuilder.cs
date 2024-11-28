using System.Globalization;
using CQRS.Contract.Share.Static;
using CQRS.Contract.Enums;
using CQRS.Contract.Models.OKX;
using OfficeOpenXml.Drawing.Chart;

namespace CQRS.Contract.Models.OKX.Builder;

public class OKXExcelModelBuilder
{
    private OKXExcelModel _excelModel;
    public OKXExcelModelBuilder()
    {
        _excelModel = new OKXExcelModel();
    }

    #region Tool

    public string ConvertNumberExcelToNumber(string Value)
    {
        return Value.Replace(',', '.');
    }

    #endregion

    #region Set Property
    public OKXExcelModelBuilder SetSymbol(string Symbol)
    {
        _excelModel.Symbol = ConvertNumberExcelToNumber(Symbol);
        return this;
    }
    public OKXExcelModelBuilder SetOrderTime(DateTime OrderTime)
    {
        _excelModel.OrderTime = OrderTime;
        return this;
    }
    public OKXExcelModelBuilder SetSide(string Side)
    {
        if (ConvertNumberExcelToNumber(Side).Equals(Common.BUY_VIE))
        {
            _excelModel.Side = TypeSideEnum.BUY;
        }
        else
        {
            _excelModel.Side = TypeSideEnum.SELL;
        }
        return this;
    }
    public OKXExcelModelBuilder SetFillAndOrderPrice(string FillAndOrderPrice)
    {
        _excelModel.FillAndOrderPrice = ConvertNumberExcelToNumber(FillAndOrderPrice);
        return this;
    }
    public OKXExcelModelBuilder SetFilledAndTotal(string FilledAndTotal)
    {
        _excelModel.FilledAndTotal = ConvertNumberExcelToNumber(FilledAndTotal);
        return this;
    }
    public OKXExcelModelBuilder SetFilledAndOrderValue(string FilledAndOrderValue)
    {
        _excelModel.FilledAndOrderValue = ConvertNumberExcelToNumber(FilledAndOrderValue);
        return this;
    }
    public OKXExcelModelBuilder SetTPAndSL(string TPAndSL)
    {
        _excelModel.TPAndSL = ConvertNumberExcelToNumber(TPAndSL);
        return this;
    }
    public void SetSymbol_Prefix()
    {
        if (
            !string.IsNullOrEmpty(_excelModel.Symbol) &&
            _excelModel.Symbol.Contains(Common.SlashCharacters) &&
            Enum.TryParse(_excelModel.Symbol.Split(Common.SlashCharacters)[0], out SymbolCoinEnums symbolCoinEnums_prefix))
        {
            _excelModel.Symbol_Prefix = symbolCoinEnums_prefix;
        }
        else
        {
            _excelModel.Symbol_Prefix = SymbolCoinEnums.NotYet;
        }
        _excelModel.Symbol_Prefix = _excelModel.Symbol_Prefix;
    }
    public void SetSymbol_Suffix()
    {
        if (
            !string.IsNullOrEmpty(_excelModel.Symbol) &&
            _excelModel.Symbol.Contains(Common.SlashCharacters) &&
            Enum.TryParse(_excelModel.Symbol.Split(Common.SlashCharacters)[1], out SymbolCoinEnums symbolCoinEnums_suffix))
        {
            _excelModel.Symbol_Suffix = symbolCoinEnums_suffix;
        }
        else
        {
            _excelModel.Symbol_Suffix = SymbolCoinEnums.NotYet;
        }
        _excelModel.Symbol_Suffix = _excelModel.Symbol_Suffix;
    }
    public void SetFillAndOrderPrice_Prefix()
    {
        if (
            !string.IsNullOrEmpty(_excelModel.FillAndOrderPrice) &&
            _excelModel.FillAndOrderPrice.Contains(Common.SpaceCharacters))
        {
            _excelModel.FillAndOrderPrice_Prefix = double.Parse(_excelModel.FillAndOrderPrice.Split(Common.SpaceCharacters)[0], CultureInfo.InvariantCulture);
        }
        else
        {
            _excelModel.FillAndOrderPrice_Prefix = 0;
        }
    }
    public void SetFillAndOrderPrice_Suffix()
    {
        if (
            !string.IsNullOrEmpty(_excelModel.FillAndOrderPrice) &&
            _excelModel.FillAndOrderPrice.Contains(Common.SpaceCharacters))
        {
            _excelModel.FillAndOrderPrice_Suffix = double.Parse(_excelModel.FillAndOrderPrice.Split(Common.SpaceCharacters)[1], CultureInfo.InvariantCulture);
        }
        else
        {
            _excelModel.FillAndOrderPrice_Suffix = 0;
        }
    }
    public void SetFilledAndTotal_Prefix()
    {
        if (!string.IsNullOrEmpty(_excelModel.FilledAndTotal) && _excelModel.FilledAndTotal.Contains(Common.SpaceCharacters))
        {
            _excelModel.FilledAndTotal_Prefix = _excelModel.FilledAndTotal.Split(Common.SpaceCharacters)[0];
        }
        else
        {
            _excelModel.FilledAndTotal_Prefix = string.Empty;
        }

        SetFilledAndTotal_Prefix_Value();
        SetFilledAndTotal_Prefix_Symbol();
    }
    public void SetFilledAndTotal_Prefix_Value()
    {
        if (!string.IsNullOrEmpty(_excelModel.FilledAndTotal_Prefix) && _excelModel.FilledAndTotal_Prefix.Contains(Common.Empty))
        {
            _excelModel.FilledAndTotal_Prefix_Value = _excelModel.FilledAndTotal_Prefix.Split(Common.Empty)[0];
        }
        else
        {
            _excelModel.FilledAndTotal_Prefix_Value = string.Empty;
        }
    }
    public void SetFilledAndTotal_Prefix_Symbol()
    {
        if (!string.IsNullOrEmpty(_excelModel.FilledAndTotal_Prefix) && _excelModel.FilledAndTotal_Prefix.Contains(Common.Empty))
        {
            _excelModel.FilledAndTotal_Prefix_Symbol = _excelModel.FilledAndTotal_Prefix.Split(Common.Empty)[1];
        }
        else
        {
            _excelModel.FilledAndTotal_Prefix_Symbol = string.Empty;
        }
    }
    public void SetFilledAndTotal_Suffix()
    {
        if (!string.IsNullOrEmpty(_excelModel.FilledAndTotal) && _excelModel.FilledAndTotal.Contains(Common.SpaceCharacters))
        {
            _excelModel.FilledAndTotal_Suffix = _excelModel.FilledAndTotal.Split(Common.SpaceCharacters)[1];
        }
        else
        {
            _excelModel.FilledAndTotal_Suffix = string.Empty;
        }

        SetFilledAndTotal_Suffix_Value();
        SetFilledAndTotal_Suffix_Symbol();
    }
    public void SetFilledAndTotal_Suffix_Value()
    {
        if (!string.IsNullOrEmpty(_excelModel.FilledAndTotal_Suffix) && _excelModel.FilledAndTotal_Suffix.Contains(Common.Empty))
        {
            _excelModel.FilledAndTotal_Suffix_Value = double.Parse(_excelModel.FilledAndTotal_Suffix.Split(Common.Empty)[0], CultureInfo.InvariantCulture);
        }
        else
        {
            _excelModel.FilledAndTotal_Suffix_Value = 0;
        }
    }
    public void SetFilledAndTotal_Suffix_Symbol()
    {
        if (!string.IsNullOrEmpty(_excelModel.FilledAndTotal_Suffix) && _excelModel.FilledAndTotal_Suffix.Contains(Common.Empty))
        {
            _excelModel.FilledAndTotal_Suffix_Symbol = _excelModel.FilledAndTotal_Suffix.Split(Common.Empty)[1];
        }
        else
        {
            _excelModel.FilledAndTotal_Suffix_Symbol = string.Empty;
        }
    }
    public void SetFilledAndOrderValue_Prefix()
    {
        if (!string.IsNullOrEmpty(_excelModel.FilledAndOrderValue) && _excelModel.FilledAndOrderValue.Contains(Common.SpaceCharacters))
        {
            _excelModel.FilledAndOrderValue_Prefix = double.Parse(_excelModel.FilledAndOrderValue.Split(Common.SpaceCharacters)[0].Replace('$', ' '), CultureInfo.InvariantCulture);
        }
        else
        {
            _excelModel.FilledAndOrderValue_Prefix = 0;
        }
    }
    public void SetFilledAndOrderValue_Suffix()
    {
        if (!string.IsNullOrEmpty(_excelModel.FilledAndOrderValue) && _excelModel.FilledAndOrderValue.Contains(Common.SpaceCharacters))
        {
            _excelModel.FilledAndOrderValue_Suffix = _excelModel.FilledAndOrderValue.Split(Common.SpaceCharacters)[1];
        }
        else
        {
            _excelModel.FilledAndOrderValue_Suffix = string.Empty;
        }
    }

    public OKXExcelModelBuilder SetFee(string Fee)
    {
        _excelModel.Fee = Fee;
        return this;
    }

    public void SetFee_Value()
    {
        if (!string.IsNullOrEmpty(_excelModel.Fee) && _excelModel.Fee.Contains(Common.Empty))
        {
            _excelModel.Fee_Value = _excelModel.Fee.Split(Common.Empty)[0];
        }
        else
        {
            _excelModel.Fee_Value = string.Empty;
        }
    }

    public void SetFee_Symbol()
    {
        if (!string.IsNullOrEmpty(_excelModel.Fee) && _excelModel.Fee.Contains(Common.Empty))
        {
            _excelModel.Fee_Symbol = _excelModel.Fee.Split(Common.Empty)[1];
        }
        else
        {
            _excelModel.Fee_Symbol = string.Empty;
        }
    }

    public void SetTP()
    {
        if (!string.IsNullOrEmpty(_excelModel.TPAndSL) && _excelModel.TPAndSL.Contains(Common.SpaceCharacters))
        {
            _excelModel.TP = _excelModel.TPAndSL.Split(Common.SpaceCharacters)[0];
        }
        else
        {
            _excelModel.TP = string.Empty;
        }
    }
    public void SetSL()
    {
        if (!string.IsNullOrEmpty(_excelModel.TPAndSL) && _excelModel.TPAndSL.Contains(Common.SpaceCharacters))
        {
            _excelModel.SL = _excelModel.TPAndSL.Split(Common.SpaceCharacters)[1];
        }
        else
        {
            _excelModel.SL = string.Empty;
        }
    }

    public void SetCapital()
    {
        var firstNumber = _excelModel.FilledAndOrderValue_Prefix * (_excelModel.FilledAndTotal_Suffix_Value / 2);
        var secondNumber = _excelModel.FillAndOrderPrice_Suffix * (_excelModel.FilledAndTotal_Suffix_Value / 2);

        var sum = firstNumber + secondNumber;
        _excelModel.Capital = (_excelModel.FilledAndOrderValue_Prefix * (_excelModel.FilledAndTotal_Suffix_Value / 2) + _excelModel.FillAndOrderPrice_Suffix * (_excelModel.FilledAndTotal_Suffix_Value / 2)).ToString();
    }

    public void SetProfit()
    {
        _excelModel.Profit = (_excelModel.FillAndOrderPrice_Suffix * _excelModel.FilledAndTotal_Suffix_Value).ToString();

        switch (_excelModel.Side)
        {
            case TypeSideEnum.BUY:
                _excelModel.Profit = _excelModel.Profit + " " + _excelModel.Symbol_Prefix;
                break;
            case TypeSideEnum.SELL:
                _excelModel.Profit = _excelModel.Profit + " " + _excelModel.Symbol_Suffix;
                break;
            default:
                break;
        }
    }

    public void SetProfit_Value()
    {
        // if(!string.IsNullOrEmpty(_excelModel.Profit) && _excelModel.Profit.Contains(Common.Empty))
        // {
        //     _excelModel.Profit_Value = _excelModel.Profit.Split(Common.Empty)[0];
        // }
        // else
        // {
        //     _excelModel.Profit_Value = string.Empty;
        // }
    }

    public void SetProfit_Symbol()
    {
        // if(!string.IsNullOrEmpty(_excelModel.Profit) && _excelModel.Profit.Contains(Common.Empty))
        // {
        //     _excelModel.Profit_Symbol = _excelModel.Profit.Split(Common.Empty)[1];
        // }
        // else
        // {
        //     _excelModel.Profit_Symbol = string.Empty;
        // }
    }
    #endregion


    public OKXExcelModel Build()
    {
        SetSymbol_Prefix();
        SetSymbol_Suffix();

        SetFillAndOrderPrice_Prefix();
        SetFillAndOrderPrice_Suffix();

        SetFilledAndTotal_Prefix();
        SetFilledAndTotal_Suffix();

        SetFilledAndOrderValue_Prefix();
        SetFilledAndOrderValue_Suffix();

        SetTP();
        SetSL();

        SetProfit();

        SetCapital();

        SetFee_Value();
        SetFee_Symbol();
        return _excelModel;
    }
}