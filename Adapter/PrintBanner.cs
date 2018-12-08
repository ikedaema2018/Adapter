using System;
namespace Adapter
{
    public class PrintBanner: Banner, Print
    {
        public PrintBanner(string str):base(str) {
        }
        public void PrintWeak() {
            ShowWithParen();
        }
        public void PrintStrong() {
            ShowWithAster();
        }
    }
}
