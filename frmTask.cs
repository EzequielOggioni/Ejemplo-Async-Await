using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace awaitasync
{
    public partial class frmTask : Form
    {
        public frmTask()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Crea las llamada a las tarea y las espera para mostrar el resultado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnTareas_Click(object sender, EventArgs e)
        {


            //corre la tarea MetodoConDelayAsync
            Task<int> tareaDelay = this.MetodoConDelayAsync();

            //corre la tarea CrearHiloNuevoAsync
            Task<int> TareaHiloNuevo = this.CrearHiloNuevoAsync();


            MessageBox.Show("paso las task");


            // espera el resultado de las tareas pero en un hilo secundario
            int resultadoTareaDelay = await tareaDelay;
            int resultadoHiloNuevo = await TareaHiloNuevo;

            MessageBox.Show(resultadoTareaDelay.ToString());
            MessageBox.Show(resultadoHiloNuevo.ToString());

        }


        public int MetodoConDelay()
        {

            Task.Delay(2000).Wait();
            MessageBox.Show("probando delay");
            return 1;


        }

        public async Task<int> MetodoConDelayAsync()
        {

            //ejecuta la tarea en un hilo secundario
            await Task.Delay(2000);
            MessageBox.Show("probando delay");
            return 1;


        }

        public async Task<int> CrearHiloNuevoAsync()
        {
            //Crea la tarea pero no la ejecuta
            Task<int>  tareaInterna = new Task<int>(()=>
            {

                return MetodoWhile();

            });


            //Comieza a correr la tarea
            tareaInterna.Start();

            //retorna el hilo principal y continua en uno secundario la ejecucion de la tarea
            return await tareaInterna;
                
            
        }

        public int MetodoWhile()
        {


            double i = 1;

            while (i < 500000000)
                i++;

            this.Invoke((MethodInvoker)delegate () { MessageBox.Show("probando hilo nuevo"); });

            return 5;


        }

        private  void  btnSync_Click(object sender, EventArgs e)
        {


            int resultadoTareaDelay =  this.MetodoConDelay();


            int resultadoMetodoWhile  = this.MetodoWhile();


            MessageBox.Show("paso las task");

         

            MessageBox.Show(resultadoTareaDelay.ToString());
            MessageBox.Show(resultadoMetodoWhile.ToString());
        }

    }
}
