using System;
using MathNet.Numerics.Distributions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.Distributions;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rd_Uniforme.Checked = true;
        }

        //Variables Para Distribuciones
        int U_minimo = 0;
        int U_maximo = 0;

        double N_desviacion = 0;
        double N_media = 0;

        double E_lambda = 0;

        double P_lanmdaOmedia = 0;

        double TamañoMuestra = 0;
        double Intervalo = 0;

        //Variables para el programa
        Random rnd = new Random();
        double random = 0;
        double random2 = 0;
        int contadorBoxMuller = 1;
        double sumaConvolucion = 0;

        double VariableAleatoria = 0;

        double extremo_minimo = 0;
        double extremo_maximo = 0;

        double ancho_intervalo = 0;

        double chiCorreccion = 0;

        //Variables Para El histograma
        double limiteInferior = 0;
        double limiteSuperior = 0;
        int frecuenciaObservada = 0;
        double frecuenciaEsperada = 0;
        int frecuenciaObservadaAC = 0;
        double frecuenciaEsperadaAC = 0;
        double marcaClase = 0;

        //Variables Para Chi Cuadrado
        double ChiCuadC = 0;
        double ChiCAcum = 0;

        //Variables Para KS

        private void btn_generar_Click(object sender, EventArgs e)
        {
            dgv_Histograma.Rows.Clear();
            histograma.Series.Clear();
            Lista_Randoms.Items.Clear();

            frecuenciaObservada = 0;
            frecuenciaObservadaAC = 0;
            frecuenciaEsperadaAC = 0;
            ChiCAcum = 0;
            extremo_minimo = 0;
            extremo_maximo = 0;
            contadorBoxMuller = 1;
            sumaConvolucion = 0;



            if (rd_Uniforme.Checked == true)
            {
                if (txt_UniformeMinimo.Text != "" && txt_UniformeMaximo.Text != "" && txt_muestra.Text != "" && cmb_intervalos.SelectedIndex != -1)
                {
                    U_minimo = Convert.ToInt32(txt_UniformeMinimo.Text);
                    U_maximo = Convert.ToInt32(txt_UniformeMaximo.Text);
                    TamañoMuestra = Convert.ToInt32(txt_muestra.Text);
                    Intervalo = Convert.ToInt32(cmb_intervalos.SelectedItem);

                    if (U_minimo >= U_maximo)
                    {
                        MessageBox.Show("Porfavor ingrese un minimo menor al maximo");
                    }
                    else
                    {
                        for (int i = 0; i < TamañoMuestra; i++)
                        {
                            GenerarRandoms();

                            VariableAleatoria = U_minimo + (random * (U_maximo - U_minimo));
                            EncontrarExtremos(i);
                            Lista_Randoms.Items.Add(VariableAleatoria);
                        }
                        txt_chiCuadrado.Text = Convert.ToString(getChiMaximo(Convert.ToInt32(Intervalo), 0.05));
                        GenerarHistograma();
                    }

                }
                else
                {
                    MessageBox.Show("Porfavor llene todos los campos");
                }
            }

            if (rd_Normal.Checked == true)
            {
                if (txt_NormalDesviacion.Text != "" && txt_NormalPromedio.Text != "" && txt_muestra.Text != "" && cmb_intervalos.SelectedIndex != -1)
                {
                    N_desviacion = Convert.ToDouble(txt_NormalDesviacion.Text);
                    N_media = Convert.ToDouble(txt_NormalPromedio.Text);
                    TamañoMuestra = Convert.ToInt32(txt_muestra.Text);
                    Intervalo = Convert.ToInt32(cmb_intervalos.SelectedItem);

                    if (chk_boxMuller.Checked == false && chk_convolucion.Checked == false)
                    {
                        MessageBox.Show("Por favor seleccione algun metodo");
                    }
                    else
                    {
                        if (chk_boxMuller.Checked == true)
                        {
                            /*for (int i = 0; i < TamañoMuestra; i++)
                            {
                                contadorBoxMuller++;
                                GenerarRandoms();
                                random2 = GenerarRandoms();
                                if (contadorBoxMuller % 2 == 0)
                                {
                                    VariableAleatoria = N_media + ((Math.Sqrt(-2 * Math.Log(1 - random)) * Math.Cos(2 * Math.PI * random2)) * N_desviacion);
                                }
                                else
                                {
                                    VariableAleatoria = N_media + ((Math.Sqrt(-2 * Math.Log(1 - random)) * Math.Sin(2 * Math.PI * random2)) * N_desviacion);
                                }
                                EncontrarExtremos(i);
                                Lista_Randoms.Items.Add(VariableAleatoria);
                            }

                            txt_chiCuadrado.Text = Convert.ToString(getChiMaximo(Convert.ToInt32(Intervalo) - 2, 0.05));
                            GenerarHistograma();*/


                            for (int i = 0; i < TamañoMuestra; i++)
                            {
                                for (int x = 0; x < 12; x++)
                                {
                                    GenerarRandoms();
                                    sumaConvolucion += random;
                                }


                                VariableAleatoria = ((sumaConvolucion - 6) * N_desviacion) + N_media;
                                EncontrarExtremos(i);
                                Lista_Randoms.Items.Add(VariableAleatoria);
                                sumaConvolucion = 0;
                            }

                            txt_chiCuadrado.Text = Convert.ToString(getChiMaximo(Convert.ToInt32(Intervalo) - 2, 0.05));
                            GenerarHistograma();

                        }
                        else
                        {
                            for (int i = 0; i < TamañoMuestra; i++)
                            {
                                for (int x = 0; x < 12; x++)
                                {
                                    GenerarRandoms();
                                    sumaConvolucion += random;
                                }


                                VariableAleatoria = ((sumaConvolucion - 6) * N_desviacion) + N_media;
                                EncontrarExtremos(i);
                                Lista_Randoms.Items.Add(VariableAleatoria);
                                sumaConvolucion = 0;
                            }

                            txt_chiCuadrado.Text = Convert.ToString(getChiMaximo(Convert.ToInt32(Intervalo) - 2, 0.05));
                            GenerarHistograma();
                        }


                    }

                }
                else
                {
                    MessageBox.Show("Porfavor llene todos los campos");
                }
            }

            if (rd_ExponencialNegativa.Checked == true)
            {
                if (txt_ExponencialLambda.Text != "" && txt_muestra.Text != "" && cmb_intervalos.SelectedIndex != -1)
                {
                    E_lambda = Convert.ToDouble(txt_ExponencialLambda.Text);
                    TamañoMuestra = Convert.ToInt32(txt_muestra.Text);
                    Intervalo = Convert.ToInt32(cmb_intervalos.SelectedItem);

                    for (int i = 0; i < TamañoMuestra; i++)
                    {
                        GenerarRandoms();

                        VariableAleatoria = (-1 / E_lambda) * (Math.Log10(1 - random));
                        EncontrarExtremos(i);
                        Lista_Randoms.Items.Add(VariableAleatoria);
                    }

                    txt_chiCuadrado.Text = Convert.ToString(getChiMaximo(Convert.ToInt32(Intervalo) - 1, 0.05));
                    GenerarHistograma();
                }
                else
                {
                    MessageBox.Show("Porfavor llene todos los campos");
                }
            }

            if (rd_Poisson.Checked == true)
            {
                if (txt_PoissonLambda.Text != "" && txt_muestra.Text != "" && cmb_intervalos.SelectedIndex != -1)
                {
                    P_lanmdaOmedia = Convert.ToDouble(txt_PoissonLambda.Text);
                    TamañoMuestra = Convert.ToInt32(txt_muestra.Text);
                    Intervalo = Convert.ToInt32(cmb_intervalos.SelectedItem);


                    List<double> listado = new List<double>();

                    //listado.Sort();
                    for (int i = 0; i < TamañoMuestra; i++)
                    {
                        listado.Add(seriePpoisson_def(P_lanmdaOmedia));
                    }
                    foreach (double item in listado)
                    {
                        Lista_Randoms.Items.Add(Math.Round(item, 4));
                    }



                    // chiCorreccion = (Intervalo) - 1, 0.05);
                    txt_chiCuadrado.Text = Convert.ToString(getChiMaximo(Convert.ToInt32(Intervalo) - 1, 0.05));
                    GenerarHistograma();
                }
                else
                {
                    MessageBox.Show("Porfavor llene todos los campos");
                }
            }

        }


        public void GenerarHistograma()
        {

            ancho_intervalo = ((extremo_maximo - extremo_minimo) / Intervalo) + 0.001;

            for (int i = 0; i < Intervalo; i++)
            {
                if (i == 0)
                {
                    limiteInferior = extremo_minimo;
                    limiteSuperior = extremo_minimo + ancho_intervalo;

                    foreach (double item in Lista_Randoms.Items)
                    {
                        if (item >= limiteInferior && item < limiteSuperior)
                        {
                            frecuenciaObservada++;
                        }
                    }

                    marcaClase = (limiteInferior + limiteSuperior) / 2;
                    FrecuenciasDistribuciones(limiteInferior, limiteSuperior, E_lambda, N_media, N_desviacion, P_lanmdaOmedia);
                    frecuenciaObservadaAC = frecuenciaObservada;
                    frecuenciaEsperadaAC = frecuenciaEsperada;

                    ChiCuadC = Math.Pow(frecuenciaObservada - frecuenciaEsperada, 2) / frecuenciaEsperada;
                    ChiCAcum += ChiCuadC;

                    dgv_Histograma.Rows.Add(Math.Round(limiteInferior, 4), Math.Round(limiteSuperior, 4),
                        Math.Round(marcaClase, 4), frecuenciaObservada, Math.Round(frecuenciaEsperada, 4),
                        frecuenciaObservadaAC, Math.Round(frecuenciaEsperada, 4),
                        Math.Round(ChiCuadC, 4), Math.Round(ChiCAcum, 4));

                }
                else
                {
                    limiteInferior = limiteSuperior;
                    limiteSuperior += ancho_intervalo;

                    frecuenciaObservada = 0;

                    foreach (double item in Lista_Randoms.Items)
                    {
                        if (item >= limiteInferior && item < limiteSuperior)
                        {
                            frecuenciaObservada++;
                        }
                    }

                    marcaClase = (limiteInferior + limiteSuperior) / 2;
                    FrecuenciasDistribuciones(limiteInferior, limiteSuperior, E_lambda, N_media, N_desviacion, P_lanmdaOmedia);
                    frecuenciaObservadaAC += frecuenciaObservada;
                    frecuenciaEsperadaAC += frecuenciaEsperada;

                    ChiCuadC = Math.Pow(frecuenciaObservada - frecuenciaEsperada, 2) / frecuenciaEsperada;
                    ChiCAcum += ChiCuadC;

                    dgv_Histograma.Rows.Add(Math.Round(limiteInferior, 4), Math.Round(limiteSuperior, 4),
                        Math.Round(marcaClase, 4), frecuenciaObservada, Math.Round(frecuenciaEsperada, 4),
                        frecuenciaObservadaAC, Math.Round(frecuenciaEsperadaAC, 4),
                        Math.Round(ChiCuadC, 4), Math.Round(ChiCAcum, 4));
                }

                string intervalo = Convert.ToString(Math.Round(limiteInferior, 4)) + " - " + Convert.ToString(Math.Round(limiteSuperior, 4));
                Series serieGR = histograma.Series.Add(intervalo);
                serieGR.Points.AddXY("Intervalos", frecuenciaObservada);
            }

            lbl_chi.Visible = true;

            if (ChiCAcum <= double.Parse(txt_chiCuadrado.Text))
            //if (ChiCAcum <= chiCorreccion)
            {
                lbl_chi.Text = "No se rechaza la hipotesis Planteada";
                lbl_chi.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                lbl_chi.Text = "Se rechaza la hipotesis Planteada";
                lbl_chi.BackColor = System.Drawing.Color.Red;
            }

        }




        public double FrecuenciasDistribuciones(double minimo, double maximo, double lambda, double media, double desviacion, double poisonMedia)
        {
            if (rd_Uniforme.Checked == true)
            {
                frecuenciaEsperada = TamañoMuestra / Intervalo;
            }

            if (rd_Normal.Checked == true)
            {
                frecuenciaEsperada = (FrecuenciaNormal(maximo, media, desviacion) - FrecuenciaNormal(minimo, media, desviacion)) * TamañoMuestra;
            }

            if (rd_ExponencialNegativa.Checked == true)
            {
                frecuenciaEsperada = (FrecuenciaExponencial(lambda, maximo) - FrecuenciaExponencial(lambda, minimo)) * TamañoMuestra;
            }

            if (rd_Poisson.Checked == true)
            {
                frecuenciaEsperada = FrecuenciaPoisson(TamañoMuestra, poisonMedia); // chequear
            }

            return frecuenciaEsperada;
        }




        private void EncontrarExtremos(int vuelta)
        {

            if (vuelta == 0)
            {
                extremo_maximo = VariableAleatoria;
                extremo_minimo = VariableAleatoria;
            }
            else
            {
                if (VariableAleatoria > extremo_maximo)
                {
                    extremo_maximo = VariableAleatoria;
                }

                if (VariableAleatoria < extremo_minimo)
                {
                    extremo_minimo = VariableAleatoria;
                }
            }

        }

        public double GenerarRandoms()
        {

            random = rnd.NextDouble();

            return random;
        }







        private void rd_Uniforme_Click(object sender, EventArgs e)
        {
            txt_UniformeMinimo.Visible = true;
            txt_UniformeMaximo.Visible = true;
            label4.Visible = true;
            label2.Visible = true;

            txt_NormalPromedio.Visible = false;
            txt_NormalDesviacion.Visible = false;
            label3.Visible = false;
            label1.Visible = false;
            chk_boxMuller.Visible = false;
            chk_convolucion.Visible = false;

            txt_ExponencialLambda.Visible = false;
            label5.Visible = false;

            txt_PoissonLambda.Visible = false;
            label7.Visible = false;
        }

        private void rd_Normal_Click(object sender, EventArgs e)
        {
            txt_UniformeMinimo.Visible = false;
            txt_UniformeMaximo.Visible = false;
            label4.Visible = false;
            label2.Visible = false;

            txt_NormalPromedio.Visible = true;
            txt_NormalDesviacion.Visible = true;
            label3.Visible = true;
            label1.Visible = true;
            chk_boxMuller.Visible = true;
            chk_convolucion.Visible = true;

            txt_ExponencialLambda.Visible = false;
            label5.Visible = false;

            txt_PoissonLambda.Visible = false;
            label7.Visible = false;
        }

        private void rd_ExponencialNegativa_Click(object sender, EventArgs e)
        {
            txt_UniformeMinimo.Visible = false;
            txt_UniformeMaximo.Visible = false;
            label4.Visible = false;
            label2.Visible = false;

            txt_NormalPromedio.Visible = false;
            txt_NormalDesviacion.Visible = false;
            label3.Visible = false;
            label1.Visible = false;
            chk_boxMuller.Visible = false;
            chk_convolucion.Visible = false;

            txt_ExponencialLambda.Visible = true;
            label5.Visible = true;

            txt_PoissonLambda.Visible = false;
            label7.Visible = false;

        }

        private void rd_Poisson_Click(object sender, EventArgs e)
        {
            txt_UniformeMinimo.Visible = false;
            txt_UniformeMaximo.Visible = false;
            label4.Visible = false;
            label2.Visible = false;

            txt_NormalPromedio.Visible = false;
            txt_NormalDesviacion.Visible = false;
            label3.Visible = false;
            label1.Visible = false;
            chk_boxMuller.Visible = false;
            chk_convolucion.Visible = false;

            txt_ExponencialLambda.Visible = false;
            label5.Visible = false;

            txt_PoissonLambda.Visible = true;
            label7.Visible = true;
        }




        public double FrecuenciaExponencial(double x, double lambda)
        {
            MathNet.Numerics.Distributions.Exponential resultado = new MathNet.Numerics.Distributions.Exponential(lambda);
            return resultado.CumulativeDistribution(x);
        }
        public double FrecuenciaNormal(double x, double mu, double sigma)
        {
            MathNet.Numerics.Distributions.Normal resultado = new MathNet.Numerics.Distributions.Normal(mu, sigma);
            return resultado.CumulativeDistribution(x);
        }

        public double FrecuenciaPoisson(double x, double lambda)
        {
            Poisson resultado = new MathNet.Numerics.Distributions.Poisson(lambda);
            return resultado.CumulativeDistribution(x);

        }
        public double seriePpoisson_def(double lambda)
        {
            Random rnd = new Random();
            return MathNet.Numerics.Distributions.Poisson.Sample(lambda);
        }
        public List<double> seriePoisson(double lambda) // metodo agregado del apunte
        {
            double p = 1;
            int x = -1;
            double a = Math.Exp(-lambda);
            List<double> lista = new List<double>();
            var rnd = new Random();
            do
            {
                var u = rnd.NextDouble();
                p = p * u;
                x = x + 1;
            }
            while (p >= a);
            lista.Add(x);
            return lista;

            //return x;
        }



        public double getChiMaximo(int cantidadIntervalos, double alfa)
        {
            return (ChiSquared.InvCDF(cantidadIntervalos - 1, 1 - alfa));
        }



        private void chk_boxMuller_Click(object sender, EventArgs e)
        {
            chk_convolucion.Checked = false;
        }

        private void chk_convolucion_Click(object sender, EventArgs e)
        {
            chk_boxMuller.Checked = false;
        }
    }
}
