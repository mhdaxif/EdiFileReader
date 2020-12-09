using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEdiReader
{
    public static class EdiParser
    {
        public static EdiModel ParseData(StreamReader fileStream)
        {
            var _head = new HEAD();
            var _dEFINEMEAS = new DEFINEMEAS();
            var _mTSECT = new MTSECT();
            var _FREQ = new FREQ();

            var _ZROT = new ZROT();
            var _ZXXR = new ZXXR();
            var _ZXXI = new ZXXI();
            var _ZXX_VAR = new ZXX_VAR();
            var _ZXYR = new ZXYR();
            var _ZXYI = new ZXYI();
            var _ZXY_VAR = new ZXY_VAR();
            var _ZYXR = new ZYXR();
            var _ZYXI = new ZYXI();
            var _ZYX_VAR = new ZYX_VAR();
            var _ZYYR = new ZYYR();
            var _ZYYI = new ZYYI();
            var _ZYY_VAR = new ZYY_VAR();
            var _TXR_EXP = new TXR_EXP();

            var _TXI_EXP = new TXI_EXP();
            var _TXVAR_EXP = new TXVAR_EXP();
            var _TYR_EXP = new TYR_EXP();
            var _TYI_EXP = new TYI_EXP();
            var _TYVAR_EXP = new TYVAR_EXP();
            var index = 1;


            string line;
            while ((line = fileStream.ReadLine()) != null)
            {
                switch (index)
                {
                    case 3:
                        _head.DATAID = line.Split("=")[1];
                        break;

                    case 4:
                        _head.ACQBY = line.Split("=")[1];
                        break;

                    case 5:
                        _head.FILEBY = line.Split("=")[1];
                        break;

                    case 6:
                        _head.ACQDATE = line.Split("=")[1];
                        break;
                    case 7:
                        _head.FILEDATE = DateTime.Parse(line.Split("=")[1]);
                        break;

                    case 8:
                        _head.PROSPECT = line.Split("=")[1];
                        break;

                    case 9:
                        _head.Loc = line.Split("=")[1];
                        break;

                    case 10:
                        _head.LAT = line.Split("=")[1];
                        break;

                    case 11:
                        _head.LONG = line.Split("=")[1];
                        break;

                    case 12:
                        _head.ELEV = float.Parse(line.Split("=")[1]);
                        break;

                    case 13:
                        _head.STDVERS = float.Parse(line.Split("=")[1]);
                        break;

                    case 14:
                        _head.PROGVERS = float.Parse(line.Split("=")[1]);
                        break;

                    case 15:
                        _head.PROGDATE = line.Split("=")[1];
                        break;

                    case 16:
                        _head.MAXSCT = float.Parse(line.Split("=")[1]);
                        break;

                    case 17:
                        _head.EMPTY = line.Split("=")[1];
                        break;

                    case 22:
                        _dEFINEMEAS.MAXCHAN = float.Parse(line.Split("=")[1]);
                        break;
                    case 23:
                        _dEFINEMEAS.MAXRUN = float.Parse(line.Split("=")[1]);
                        break;
                    case 24:
                        _dEFINEMEAS.MAXMEAS = float.Parse(line.Split("=")[1]);
                        break;
                    case 25:
                        _dEFINEMEAS.units = line.Split("=")[1];
                        break;
                    case 26:
                        _dEFINEMEAS.REFLAT = line.Split("=")[1];
                        break;
                    case 27:
                        _dEFINEMEAS.REFLONG = line.Split("=")[1];
                        break;
                    case 28:
                        _dEFINEMEAS.REFELEV = float.Parse(line.Split("=")[1]);
                        break;
                    case 29:
                    case 30:
                    case 31:
                    case 32:
                    case 33:
                        var dataArr = line.Split("=");
                        var hMEAS = new HMEAS
                        {
                            ID = dataArr[1].Trim().Split(" ")[0],
                            CHTYPE = dataArr[2].Trim().Split(" ")[0],
                            X = dataArr[3].Trim().Split(" ")[0],
                            Y = dataArr[4].Trim().Split(" ")[0],
                            YAZM = dataArr[5].Trim().Split(" ")[0],
                        };
                        _dEFINEMEAS.HMEASList.Add(hMEAS);
                        break;
                    case 35:
                        _mTSECT.SECTID = line.Split("=")[1];
                        break;

                    case 36:
                        _mTSECT.NFREQ = float.Parse(line.Split("=")[1]);
                        break;
                    case 37:
                        _mTSECT.HX = float.Parse(line.Split("=")[1]);
                        break;
                    case 38:
                        _mTSECT.HY = float.Parse(line.Split("=")[1]);
                        break;
                    case 39:
                        _mTSECT.hz = float.Parse(line.Split("=")[1]);
                        break;
                    case 40:
                        _mTSECT.ex = float.Parse(line.Split("=")[1]);
                        break;
                    case 41:
                        _mTSECT.ey = float.Parse(line.Split("=")[1]);
                        break;
                    case 42:
                        _FREQ.NFREQ = float.Parse(line.Split("=")[1].Split(" ")[0]);
                        _FREQ.ORDER = line.Split("=")[2].Split(" ")[0];
                        break;
                    case 43:
                        _FREQ.Data = line.Split("    ").ToList();
                        break;
                    case 46:
                        _ZROT.Data = line.Split("    ").ToList();
                        break;
                    case 47:
                        _ZXXR.ROT = float.Parse(line.Split("=")[1].Split(" ")[0]);
                        break;
                    case 48:
                        _ZXXR.Data = line.Split("    ").ToList();
                        break;
                    case 49:
                        _ZXXR.ROT = float.Parse(line.Split("=")[1].Split(" ")[0]);
                        break;
                    case 50:
                        _ZXXI.Data = line.Split("    ").ToList();
                        break;
                    case 51:
                        _ZXX_VAR.ROT = float.Parse(line.Split("=")[1].Split(" ")[0]);
                        break;
                    case 52:
                        _ZXX_VAR.Data = line.Split("    ").ToList();
                        break;
                    case 53:
                        _ZXYR.ROT = float.Parse(line.Split("=")[1].Split(" ")[0]);
                        break;
                    case 54:
                        _ZXYR.Data = line.Split("    ").ToList();
                        break;
                    case 55:
                        _ZXYI.ROT = float.Parse(line.Split("=")[1].Split(" ")[0]);
                        break;
                    case 56:
                        _ZXYI.Data = line.Split("    ").ToList();
                        break;
                    case 57:
                        _ZXY_VAR.ROT = float.Parse(line.Split("=")[1].Split(" ")[0]);
                        break;
                    case 58:
                        _ZXY_VAR.Data = line.Split("    ").ToList();
                        break;
                    case 59:
                        _ZYXR.ROT = float.Parse(line.Split("=")[1].Split(" ")[0]);
                        break;
                    case 60:
                        _ZYXR.Data = line.Split("    ").ToList();
                        break;
                    case 61:
                        _ZYXI.ROT = float.Parse(line.Split("=")[1].Split(" ")[0]);
                        break;
                    case 62:
                        _ZYXI.Data = line.Split("    ").ToList();
                        break;
                    case 63:
                        _ZYX_VAR.ROT = float.Parse(line.Split("=")[1].Split(" ")[0]);
                        break;
                    case 64:
                        _ZYX_VAR.Data = line.Split("    ").ToList();
                        break;
                    case 65:
                        _ZYYR.ROT = float.Parse(line.Split("=")[1].Split(" ")[0]);
                        break;
                    case 66:
                        _ZYYR.Data = line.Split("    ").ToList();
                        break;
                    case 67:
                        _ZYYI.ROT = float.Parse(line.Split("=")[1].Split(" ")[0]);
                        break;
                    case 68:
                        _ZYYI.Data = line.Split("    ").ToList();
                        break;
                    case 69:
                        _ZYY_VAR.ROT = float.Parse(line.Split("=")[1].Split(" ")[0]);
                        break;
                    case 70:
                        _ZYY_VAR.Data = line.Split("    ").ToList();
                        break;
                    case 71:
                        _TXR_EXP.ROT = float.Parse(line.Split("=")[1].Split(" ")[0]);
                        break;
                    case 72:
                        _TXR_EXP.Data = line.Split("    ").ToList();
                        break;
                    case 73:
                        _TXI_EXP.ROT = float.Parse(line.Split("=")[1].Split(" ")[0]);
                        break;
                    case 74:
                        _TXI_EXP.Data = line.Split("    ").ToList();
                        break;
                    case 75:
                        _TXVAR_EXP.ROT = float.Parse(line.Split("=")[1].Split(" ")[0]);
                        break;
                    case 76:
                        _TXVAR_EXP.Data = line.Split("    ").ToList();
                        break;
                    case 77:
                        _TYR_EXP.ROT = float.Parse(line.Split("=")[1].Split(" ")[0]);
                        break;
                    case 78:
                        _TYR_EXP.Data = line.Split("    ").ToList();
                        break;
                    case 79:
                        _TYI_EXP.ROT = float.Parse(line.Split("=")[1].Split(" ")[0]);
                        break;
                    case 80:
                        _TYI_EXP.Data = line.Split("    ").ToList();
                        break;
                    case 81:
                        _TYVAR_EXP.ROT = float.Parse(line.Split("=")[1].Split(" ")[0]);
                        break;
                    case 82:
                        _TYVAR_EXP.Data = line.Split("    ").ToList();
                        break;
                }

                index += 1;
            }


            var parsedData = new EdiModel
            {
                HEAD = _head,
                DEFINEMEAS = _dEFINEMEAS,
                MTSECT = _mTSECT,
                FREQ = _FREQ,
                TXI_EXP = _TXI_EXP,
                ZROT = _ZROT,
                ZXXR = _ZXXR,
                TYVAR_EXP = _TYVAR_EXP,
                ZXX_VAR = _ZXX_VAR,
                ZXXI = _ZXXI,
                ZXYR = _ZXYR,
                ZXYI = _ZXYI,
                ZXY_VAR = _ZXY_VAR,
                ZYXR = _ZYXR,
                ZYXI = _ZYXI,
                ZYX_VAR = _ZYX_VAR,
                ZYYR = _ZYYR,
                ZYYI = _ZYYI,
                ZYY_VAR = _ZYY_VAR,
                TXR_EXP = _TXR_EXP,
                TXVAR_EXP = _TXVAR_EXP,
                TYR_EXP = _TYR_EXP,
                TYI_EXP = _TYI_EXP,
            };

            return parsedData;
        }
    }
}
