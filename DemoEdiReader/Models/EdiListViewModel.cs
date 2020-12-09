using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEdiReader
{
    public class EdiListViewModel
    {
        public List<EdiModel> EdiList { get; set; } = new List<EdiModel>();
    }
     

    public class EdiModel
    {
        public string FileName { get; set; }
        public string ParsedData { get; set; }

        public HEAD HEAD { get; set; }
        public DEFINEMEAS DEFINEMEAS { get; set; }
        public MTSECT MTSECT { get; set; }
        public FREQ FREQ { get; set; }
        public ZROT ZROT { get; set; }
        public ZXXR ZXXR { get; set; }
        public ZXXI ZXXI { get; set; }
        public ZXX_VAR ZXX_VAR { get; set; }
        public ZXYR ZXYR { get; set; }
        public ZXYI ZXYI { get; set; }
        public ZXY_VAR ZXY_VAR { get; set; }
        public ZYXR ZYXR { get; set; }
        public ZYXI ZYXI { get; set; }
        public ZYX_VAR ZYX_VAR { get; set; }
        public ZYYR ZYYR { get; set; }
        public ZYYI ZYYI { get; set; }
        public ZYY_VAR ZYY_VAR { get; set; }
        public TXR_EXP TXR_EXP { get; set; }

        public TXI_EXP TXI_EXP { get; set; }
        public TXVAR_EXP TXVAR_EXP { get; set; }
        public TYR_EXP TYR_EXP { get; set; }
        public TYI_EXP TYI_EXP { get; set; }
        public TYVAR_EXP TYVAR_EXP { get; set; }
    }
}
