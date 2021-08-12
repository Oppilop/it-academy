using System;
using System.Drawing;

namespace laboratorio04_grupo
{
   public class CirculoColoridoPreenchido : CirculoColorido
   {
       //instanciação do objeto da classe color - forma "correta" de especificar uma cor
      public Color corAdicional = new Color(); //atributo do tipo Color
      
      //construtor sem parametros 
        public CirculoColoridoPreenchido()
        {
            //atribuindo ao objeto corAdicional o retorno da função Color.FromName() que é um objeto da classe Color
            corAdicional = Color.FromName("Blue");
        }
        
        //contrutor com parametros próprios e herdados
        public CirculoColoridoPreenchido(double x, double y, double r, string c, string p) : base(x, y, r, c)
        {
            //atribuindo ao objeto corAdicional o retorno da função Color.FromName() que é um objeto da classe Color
            corAdicional = Color.FromName(p);
        }

        //sobrescrita do ToString
        public override string ToString()
        {
            return base.ToString() + " preenchimento = " + corAdicional;
        }
    
   } 

}