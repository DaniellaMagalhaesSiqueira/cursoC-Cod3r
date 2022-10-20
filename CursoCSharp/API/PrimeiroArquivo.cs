using System;
using System.IO;

namespace CursoCSharp.API {

    public static class ExtensaoString {
        public static string ParseHome(this string path) {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix ||
                Environment.OSVersion.Platform == PlatformID.MacOSX) ?
                Environment.GetEnvironmentVariable("HOME") : 
                Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
               // Environment.OSVersion.Platform == PlatformID.Win32NT
        }
    }
    class PrimeiroArquivo {
        public static void Executar() {
            //ignora tabulações, recuos e quebra de linha (@ interpreta como literal)
            var path = @"~/primeiro_arquivo.txt".ParseHome();
            if (!File.Exists(path)) {
                using (StreamWriter sw = File.CreateText(path)) {
                    sw.WriteLine("Esse é");
                    sw.WriteLine(" o nosso");
                    sw.WriteLine(" primeiro");
                    sw.WriteLine(" arquivo!");
                }

            }
                using (StreamWriter sw = File.AppendText(path)) {
                    sw.WriteLine(" ");
                    sw.WriteLine("É possível ");
                    sw.WriteLine("adicionar mais texto.");
                }
        }
    }
}
