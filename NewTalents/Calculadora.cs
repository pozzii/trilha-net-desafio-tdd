using System.Collections.Generic;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> listahistorico;
        private string data;

        public Calculadora(string data)
        {
            listahistorico = new List<string>();
            this.data = data;
        }
        public int Somar(int numero1, int numero2)
        {
            int res = numero1 + numero2;

            listahistorico.Insert(0, "Res: " + res + " - data: " + data);
            
            return res;
        }
        
        public int Subtrair(int numero1, int numero2)
        {
            int res = numero1 - numero2;
            
            listahistorico.Insert(0, "Res: " + res + " - data: " + data);
            
            return res;
        }
        
        public int Multiplicar(int numero1, int numero2)
        {
            int res = numero1 * numero2;
            
            listahistorico.Insert(0, "Res: " + res + " - data: " + data);

            return res;
        }
        
        public int Dividir(int numero1, int numero2)
        {
            int res = numero1 / numero2;
            
            listahistorico.Insert(0, "Res: " + res + " - data: " + data);

            return res;
        }

        public List<string> Historico()
        {
            List<string> res;
            listahistorico.RemoveRange(3, listahistorico.Count - 3);
            return listahistorico;
        }
        
    }
}