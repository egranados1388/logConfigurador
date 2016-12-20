using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace logConfigurador
{
    class Program
    {
        static void Main(string[] args)
        {

            //C:/OMP-E10/Configuration/IF1Conf.txt
            String fecha = DateTime.Today.ToShortDateString();
            String  fecha_format=fecha.Replace("/", "");


            String hora = DateTime.Now.ToShortTimeString();

          // 
            using (StreamWriter sw = File.AppendText(@"\\ser-virtuales\logSis\Lam\Configuraciones\ConfLog"+fecha_format+".txt"))
            {
                sw.WriteLine("{0}", "-----------------------------------Nueva  configuracion a las " + hora  +" desde : " + Environment.MachineName + " por : " + Environment.UserName+"---------------------------------");
                sw.WriteLine("{0}", "             " + args[0] );
                sw.WriteLine("{0}", "----------------------------------------------------------------------------------------------------------------------");   
                sw.Close();
            }
//static void Main(String[] info)
  //      {


             //Cuando sea m anual desd la interface
             //string parametro = "179788";
    //          string parametro = info[0];

                       
      //      Form1 example = new Form1(parametro);
        //    example.Dispose();

            
        
        //}                             





        }
    }
}
