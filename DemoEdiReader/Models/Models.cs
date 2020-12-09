using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEdiReader
{
    public class HEAD
    {
        public string DATAID { get; set; }
        public string ACQBY { get; set; }
        public string FILEBY { get; set; }
        public string ACQDATE { get; set; }
        public DateTime? FILEDATE { get; set; }
        public string PROSPECT { get; set; }
        public string Loc { get; set; }
        public string LAT { get; set; }
        public string LONG { get; set; }
        public float ELEV { get; set; }
        public float STDVERS { get; set; }
        public float PROGVERS { get; set; }
        public string PROGDATE { get; set; }
        public float MAXSCT { get; set; }
        public string EMPTY { get; set; } //1.0E32
    }

    public class DEFINEMEAS
    {
        public float MAXCHAN { get; set; }
        public float MAXRUN { get; set; }
        public float MAXMEAS { get; set; }

        public string units { get; set; }
        public string REFLAT { get; set; }
        public string REFLONG { get; set; }
        public float REFELEV { get; set; }
        public List<HMEAS> HMEASList { get; set; } = new List<HMEAS>();
    }

    public class HMEAS
    {
        public string ID { get; set; }
        public string CHTYPE { get; set; }
        public string X { get; set; }
        public string Y { get; set; }
        public string YAZM { get; set; }
    }

    public class MTSECT
    {
        public string SECTID { get; set; }
        public float NFREQ { get; set; }
        public float HX { get; set; }
        public float HY { get; set; }
        public float hz { get; set; }
        public float ex { get; set; }
        public float ey { get; set; } 
    }


    // >FREQ NFREQ=4 ORDER=DEC //4
    // 1.00000e+0    1.00000e-1    1.00000e-2    1.00000e-3 
    public class FREQ
    {
        public float NFREQ { get; set; }
        public string ORDER { get; set; }
        public List<string> Data { get; set; } = new List<string>();
    }



    public class ZROT
    {
        public float ROT { get; set; }
        public List<string> Data { get; set; } = new List<string>();
    }

    public class ZXXR
    {
        public float ROT { get; set; }
        public List<string> Data { get; set; } = new List<string>();
    }

    public class ZXXI
    {
        public float ROT { get; set; }
        public List<string> Data { get; set; } = new List<string>();
    }


    public class ZXX_VAR
    {
        public float ROT { get; set; }
        public List<string> Data { get; set; } = new List<string>();
    }

    public class ZXYR
    {
        public float ROT { get; set; }
        public List<string> Data { get; set; } = new List<string>();
    }

    public class ZXYI
    {
        public float ROT { get; set; }
        public List<string> Data { get; set; } = new List<string>();
    }

    public class ZXY_VAR
    {
        public float ROT { get; set; }
        public List<string> Data { get; set; } = new List<string>();
    }

    public class ZYXR
    {
        public float ROT { get; set; }
        public List<string> Data { get; set; } = new List<string>();
    }

    public class ZYXI
    {
        public float ROT { get; set; }
        public List<string> Data { get; set; } = new List<string>();
    }

    public class ZYX_VAR
    {
        public float ROT { get; set; }
        public List<string> Data { get; set; } = new List<string>();
    }

    public class ZYYR
    {
        public float ROT { get; set; }
        public List<string> Data { get; set; } = new List<string>();
    }

    public class ZYYI
    {
        public float ROT { get; set; }
        public List<string> Data { get; set; } = new List<string>();
    }
    public class ZYY_VAR
    {
        public float ROT { get; set; }
        public List<string> Data { get; set; } = new List<string>();
    }

    public class TXR_EXP
    {
        public float ROT { get; set; }
        public List<string> Data { get; set; } = new List<string>();
    }

    public class TXI_EXP
    {
        public float ROT { get; set; }
        public List<string> Data { get; set; } = new List<string>();
    }

    public class TXVAR_EXP
    {
        public float ROT { get; set; }
        public List<string> Data { get; set; } = new List<string>();
    }

    public class TYR_EXP
    {
        public float ROT { get; set; }
        public List<string> Data { get; set; } = new List<string>();
    }

    public class TYI_EXP
    {
        public float ROT { get; set; }
        public List<string> Data { get; set; } = new List<string>();
    }

    public class TYVAR_EXP
    {
        public float ROT { get; set; }
        public List<string> Data { get; set; } = new List<string>();
    }

}
