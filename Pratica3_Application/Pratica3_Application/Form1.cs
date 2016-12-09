using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pratica3_Application
{
    public partial class Form1 : Form
    {
        const int TAMANHOVETOR = 99;
        const string CIRCULO = "Circulo" ;
        const string QUADRADO = "Quadrado";
        const string TRIANGULO = "Triângulo";
        const string ESFERA = "Esfera";
        const string CUBO = "Cubo";
        const string TETRAEDROREGULAR = "Tetraedro";

        private Forma[] vetorFormas = new Forma[TAMANHOVETOR];
        private int posicaoVetor = 0;
        private Forma forma;

        // Adiciona forma no vetor
        private void addFormaNoVetor(Forma forma)
        {
            try
            {
                if (forma == null)
                {
                    throw new NullFormaException();
                }
                if (posicaoVetor < TAMANHOVETOR)
                {
                    vetorFormas[posicaoVetor] = forma;
                    posicaoVetor++;
                }
                else
                {
                    throw new LimiteVetorException();
                }

            }
            catch (LimiteVetorException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NullFormaException ex2)
            {
                MessageBox.Show(ex2.Message);
            }
            
            
        }

        public Form1()
        {
            InitializeComponent();
            setVisibleTitulos(false);
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tetraédroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblForma.Text = TETRAEDROREGULAR;
            setVisibleTitulos(true);
            setCamposTetraedroRegular();
            setCamposCoordenadasTridimensional();
        }

        private void setCamposCoordenadasBidimensional()
        {
            mskTxtBxCoordX.Enabled = true;
            mskTxtBxCoordY.Enabled = true;
            mskTxtBxCoordZ.Enabled = false;
        }

        private void setCamposCoordenadasTridimensional()
        {
            setCamposCoordenadasBidimensional();
            mskTxtBxCoordZ.Enabled = true;
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string retorno = "Não";
            int contador = 0;
            bool existeCirculoEsfera = false;

            for (int i = 0; i < vetorFormas.Length; i++)
            {
                if(vetorFormas[i] == null)
                {
                    contador++;
                }
                if (vetorFormas[i] is Circulo || vetorFormas[i] is Esfera)
                {
                    existeCirculoEsfera = true;
                    for (int j = 0; j < vetorFormas.Length; j++)
                    {
                        if (i != j)
                        {
                            if (vetorFormas[j] is Circulo && vetorFormas[i] is Circulo)
                            {
                                Circulo circulo1 = (Circulo)vetorFormas[i];
                                Circulo circulo2 = (Circulo)vetorFormas[j];

                                if (Circulo.intercetam(circulo1, circulo2))
                                {
                                    retorno = "Circulos/Esferas";
                                }
                            }
                            else if (vetorFormas[j] is Esfera && vetorFormas[i] is Esfera)
                            {
                                Esfera f1 = (Esfera)vetorFormas[i];
                                Esfera f2 = (Esfera)vetorFormas[j];

                                if (Esfera.intercetam(f1, f2))
                                {
                                    retorno = "Circulos/Esferas";
                                }
                            }
                            
                        }
                    }
                }
           

            }
            
            try
            {
                if (contador == vetorFormas.Length)
                {
                    throw new VetorVazioException();

                }
                else if(!existeCirculoEsfera)
                {
                    throw new NaoExisteCiruloEsferaException();
                }
                else
                {
                    MessageBox.Show(retorno + " interceptam");
                }
            }
            catch (VetorVazioException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NaoExisteCiruloEsferaException ex2)
            {
                MessageBox.Show(ex2.Message);
            }
        }

        private void maskedTextBox9_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void desabilitaTodosOsCampos()
        {
            mskTxtBxAltura.Enabled = false;
            mskTxtBxBase.Enabled = false;
            mskTxtBxCoordX.Enabled = false;
            mskTxtBxCoordY.Enabled = false;
            mskTxtBxCoordZ.Enabled = false;
            mskTxtBxLado.Enabled = false;
            mskTxtBxRaio.Enabled = false;
            mskTxtBxAlturaBase.Enabled = false;
            mskTxtBxAlturaTetraedroRegular.Enabled = false;
        }

        private void limpaCampos()
        {
            mskTxtBxAltura.Text = "";
            mskTxtBxBase.Text = "";
            mskTxtBxCoordX.Text = "";
            mskTxtBxCoordY.Text = "";
            mskTxtBxCoordZ.Text = "";
            mskTxtBxLado.Text = "";
            mskTxtBxRaio.Text = "";
            mskTxtBxNome.Text = "";
            mskTxtBxAlturaBase.Text = "";
            mskTxtBxAlturaTetraedroRegular.Text = "";
        }

        // Campos do circulo e esfera
        private void setCamposCirculoEsfera()
        {
            desabilitaTodosOsCampos();
            mskTxtBxRaio.Enabled = true;
        }

        // Campos do quadrado/cubo
        private void setCamposQuadradoCubo()
        {
            desabilitaTodosOsCampos();
            mskTxtBxLado.Enabled = true;

        }

        // Campos do Triangulo
        private void setCamposTriangulo()
        {
            desabilitaTodosOsCampos();
            mskTxtBxBase.Enabled = true;
            mskTxtBxAltura.Enabled = true;

        }

        // Campos do tetraedro
        private void setCamposTetraedroRegular()
        {
            desabilitaTodosOsCampos();
            mskTxtBxBase.Enabled = true;
            mskTxtBxAlturaBase.Enabled = true;
            mskTxtBxAlturaTetraedroRegular.Enabled = true;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            
            try
            {
                try
                {
                    string tipo = lblForma.Text;
                    if (!tipo.Equals(TRIANGULO) && !tipo.Equals(QUADRADO) && !tipo.Equals(CIRCULO) && !tipo.Equals(ESFERA) && !tipo.Equals(CUBO) && !tipo.Equals(TETRAEDROREGULAR))
                    {
                        throw new InvalidCriarException();
                    }
                    double x = double.Parse(mskTxtBxCoordX.Text);
                    double y = double.Parse(mskTxtBxCoordY.Text);
                    double z = 0;
                    string nome = mskTxtBxNome.Text;
                    
                    if (mskTxtBxCoordZ.Enabled)
                    {
                        z = double.Parse(mskTxtBxCoordZ.Text);
                    }
                    if (nome.Equals(""))
                    {
                        throw new VazioException();
                    }
                    else if (tipo.Equals(CIRCULO))
                    {
                        double raio = double.Parse(mskTxtBxRaio.Text);
                        forma = new Circulo(x, y, raio, nome);

                    }
                    else if (tipo.Equals(QUADRADO))
                    {
                        double lado = double.Parse(mskTxtBxLado.Text);
                        forma = new Quadrado(x, y, lado, nome);
                    }
                    else if (tipo.Equals(TRIANGULO))
                    {
                        double minhaBase = double.Parse(mskTxtBxBase.Text);
                        double altura = double.Parse(mskTxtBxAltura.Text);
                        forma = new Triangulo(x, y, minhaBase, altura, nome);
                    }
                    else if (tipo.Equals(ESFERA))
                    {
                        double raio = double.Parse(mskTxtBxRaio.Text);
                        forma = new Esfera(x, y, z, raio, nome);
                    }
                    else if (tipo.Equals(CUBO))
                    {
                        double lado = double.Parse(mskTxtBxLado.Text);
                        forma = new Cubo(x, y, z, lado, nome);
                    }
                    else if (tipo.Equals(TETRAEDROREGULAR))
                    {
                        double minhaBase = double.Parse(mskTxtBxBase.Text);
                        double alturaTetraedro = double.Parse(mskTxtBxAlturaTetraedroRegular.Text);
                        double alturaBase = double.Parse(mskTxtBxAlturaBase.Text);
                        forma = new Tetraedro(x, y, z, minhaBase, alturaBase, alturaTetraedro, nome);
                    }
                    addFormaNoVetor(forma);
                    MessageBox.Show("Forma criada com sucesso!");
                    desabilitaTodosOsCampos();
                    limpaCampos();
                    setVisibleTitulos(false);
                }

                catch (InvalidCriarException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception)
                {

                    throw new InvalidValorException();
                }
            }
            catch (InvalidValorException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (VazioException ex2)
            {
                MessageBox.Show(ex2.Message);
            }
            catch (NumeroZeroException ex3)
            {
                MessageBox.Show(ex3.Message);
            }
            catch(NumeroNegativoException ex4)
            {
                MessageBox.Show(ex4.Message);
            }

            finally
            {
               
                 forma = null;
            }
           
        }

        private void setVisibleTitulos(bool opcao)
        {
            lblTitulo.Visible = opcao;
            lblForma.Visible = opcao;
        }

        private void circuloToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lblForma.Text = CIRCULO; 
            setVisibleTitulos(true);
            setCamposCirculoEsfera();
            setCamposCoordenadasBidimensional();
        }

        private void quadradoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lblForma.Text = QUADRADO;
            setVisibleTitulos(true);
            setCamposQuadradoCubo();
            setCamposCoordenadasBidimensional();
        }

        private void triânguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblForma.Text = TRIANGULO;
            setVisibleTitulos(true);
            setCamposTriangulo();
            setCamposCoordenadasBidimensional();
        }

        private void esferaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblForma.Text = ESFERA;
            setVisibleTitulos(true);
            setCamposCirculoEsfera();
            setCamposCoordenadasTridimensional();
        }

        private void cuboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblForma.Text = CUBO;
            setVisibleTitulos(true);
            setCamposQuadradoCubo();
            setCamposCoordenadasTridimensional();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void descreverFormasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int contador = vetorFormas.Length;
            double areaTotal = 0;
            double volumeTotal = 0;
            bool possuiTridimensional = false;

            for (int i = 0; i < vetorFormas.Length; i++)
            {
                if (vetorFormas[i] != null)
                {
                    MessageBox.Show(vetorFormas[i].getDescricao());
                    if (vetorFormas[i] is Esfera)
                    {
                        possuiTridimensional = true;
                        Esfera formaTemp = (Esfera) vetorFormas[i];
                        volumeTotal += formaTemp.calculaVolume();
                        areaTotal += formaTemp.calculaArea();
                        
                    }

                    else if (vetorFormas[i] is Cubo)
                    {
                        possuiTridimensional = true;
                        Cubo formaTemp = (Cubo)vetorFormas[i];
                        volumeTotal += formaTemp.calculaVolume();
                        areaTotal += formaTemp.calculaArea();

                    }
                    else if (vetorFormas[i] is Tetraedro)
                    {
                        possuiTridimensional = true;
                        Tetraedro formaTemp = (Tetraedro)vetorFormas[i];
                        volumeTotal += formaTemp.calculaVolume();
                        areaTotal += formaTemp.calculaArea();

                    }
                    else if (vetorFormas[i] is Circulo)
                    {
                        Circulo formaTemp = (Circulo)vetorFormas[i];
                 
                        areaTotal += formaTemp.calculaArea();

                    }
                    else if (vetorFormas[i] is Quadrado)
                    {
                        Quadrado formaTemp = (Quadrado)vetorFormas[i];
                        
                        areaTotal += formaTemp.calculaArea();

                    }
                    else if (vetorFormas[i] is Triangulo)
                    {
                        Triangulo formaTemp = (Triangulo)vetorFormas[i];
                      
                        areaTotal += formaTemp.calculaArea();

                    }
                    
                    contador--;
                   
                }
         
            }
            try
            {
                if (contador == vetorFormas.Length)
                {
                    throw new VetorVazioException();
    
                }
                else
                {
                    string retorno = "Area Total: " + areaTotal;
                    if (possuiTridimensional)
                    {
                        retorno += "\nVolume total: " + volumeTotal;
                    }
                    MessageBox.Show(retorno);
                }
            }
            catch (VetorVazioException ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
