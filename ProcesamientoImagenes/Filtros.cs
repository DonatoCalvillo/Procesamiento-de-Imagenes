using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ProcesamientoImagenes
{
    class Filtros
    {

        //Atributos 
        private Color rColor = new Color();
        private Color oColor = new Color();

        private Bitmap image;

        private int width, height;

        //Getter y setter
        public Bitmap getImage()
        {
            return this.image;
        }

        public void setImage(Bitmap image)
        {
            this.image = image;
            this.width = image.Width;
            this.height = image.Height;
        }

        //Metodos
        private void limpiarColores()
        {
            this.rColor = this.oColor = new Color();
        }

        //Filtros
        public Bitmap FiltroColor(string colorSeleccionado)
        {
            for (int x = 0; x < this.width; x++)
            {
                for (int y = 0; y < this.height; y++)
                {
                    //Obtenemos el color del pixel
                    
                    oColor = this.image.GetPixel(x, y);

                    //Procesamos y obtenemos el nuevo color
                    switch (colorSeleccionado)
                    {
                        case "Rojo":
                            this.rColor = Color.FromArgb(oColor.R, 0, 0);
                            break;
                        case "Azul":
                            this.rColor = Color.FromArgb(0, 0, oColor.B);
                            break;
                        case "Amarillo":
                            this.rColor = Color.FromArgb(oColor.R, oColor.G, 0);
                            break;
                        case "Verde":
                            this.rColor = Color.FromArgb(0, oColor.G, 0);
                            break;
                        case "Cian":
                            this.rColor = Color.FromArgb(0, oColor.G, oColor.B);
                            break;
                        case "Magenta":
                            this.rColor = Color.FromArgb(oColor.R, 0, oColor.B);
                            break;
                        default:
                            break;
                    }

                    //Colocamos el color en resultante
                    image.SetPixel(x, y, rColor);
                }
            }
            this.limpiarColores();
            return image;
        }

        public Bitmap FiltroNegativo()
        {
            for (int x = 0; x < this.width; x++)
            {
                for (int y = 0; y < this.height; y++)
                {
                    //Obtener el color original del pixel
                    oColor = this.image.GetPixel(x, y);

                    //Color invertido

                    rColor = Color.FromArgb(
                        255 - oColor.R,
                        255 - oColor.G,
                        255 - oColor.B);

                    //Reasignamos el color inverso al pixel
                    this.image.SetPixel(x, y, rColor);
                }
            }
            this.limpiarColores();
            return this.image;
        }

        public Bitmap FiltroACromatica()
        {
            //a = tama;o de la aberracion (El desface del pixel que tendran los colores rgb)
            int a = 4, r = 0, g = 0, b = 0;

            for (int x = 0; x < this.width; x++)
                for (int y = 0; y < this.height; y++)
                {
                    //Obtenemos el verde
                    g = this.image.GetPixel(x, y).G;

                    //Obtenemos el rojo
                    if (x + a < this.width)
                        r = this.image.GetPixel(x + a, y).R;
                    else
                        r = 0;

                    //Obtenemos el azul
                    if (x - a >= 0)
                        b = this.image.GetPixel(x - a, y).B;
                    else
                        b = 0;

                    //colocamos el pixel
                    this.image.SetPixel(x, y, Color.FromArgb(r, g, b));
                }

            return this.image;
        }

        public Bitmap FiltroEGrises()
        {
            float g = 0;

            for (int x = 0; x < this.width; x++)
                for (int y = 0; y < this.height; y++)
                {
                    //Obtenemos el color del pixel
                    this.oColor = this.image.GetPixel(x, y);

                    //Procesamos y obtenemos el nuevo color
                    //0.2126    0.7152      0.07222 - Colorimetrica, basada en percepcion humana
                    //0.299     0.587       0.114   -   Luma, basado en brillo
                    //0.267     0.678       0.0593

                    g = this.oColor.R * 0.299f + this.oColor.G * 0.587f + this.oColor.B * 0.114f;

                    this.rColor = Color.FromArgb((int)g, (int)g, (int)g);

                    //Colocamos el color resultante
                    this.image.SetPixel(x, y, this.rColor);
                }

            this.limpiarColores();
            return this.image;
        }

        public Bitmap FiltroColorizar(int paramR, int paramG, int paramB)
        {
            //Queremos colorizar con el color del usuario
            double rc = paramR / 255.0;
            double gc = paramG / 255.0;
            double bc = paramB / 255.0;

            int r = 0, g = 0, b = 0;

            //Creamos la imagen en tonos de gris
            this.FiltroEGrises();

            for (int x = 0; x < this.width; x++)
                for (int y = 0; y < this.height; y++)
                {
                    this.oColor = image.GetPixel(x, y);

                    r = (int)(this.oColor.R * rc);
                    g = (int)(this.oColor.G * gc);
                    b = (int)(this.oColor.B * bc);

                    this.image.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            this.limpiarColores();
            return this.image;
        }

        public Bitmap FiltroGradianteColores()
        {
            float r1 = 120, g1 = 230, b1 = 120;
            float r2 = 230, g2 = 100, b2 = 230;

            int r, g, b;

            float dr = (r2 - r1) / this.width;
            float dg = (g2 - g1) / this.width;
            float db = (b2 - b1) / this.width;

            //Obtenemos los tonos de gris
            this.FiltroEGrises();

            for (int x = 0; x < this.width; x++)
            {
                for (int y = 0; y < this.height; y++)
                {
                    this.oColor = this.image.GetPixel(x, y);

                    //Calculamos el color
                    r = (int)((r1 / 255.0f) * this.oColor.R);
                    g = (int)((g1 / 255.0f) * this.oColor.G);
                    b = (int)((b1 / 255.0f) * this.oColor.B);

                    if (r > 255) r = 255;
                    else if (r < 0) r = 0;

                    if (g > 255) g = 255;
                    else if (g < 0) g = 0;

                    if (b > 255) b = 255;
                    else if (b < 0) b = 0;

                    //Colocamos el color
                    this.image.SetPixel(x, y, Color.FromArgb(r, g, b));
                }

                //Avanzamos el color
                r1 = (r1 + dr);
                g1 = (g1 + dg);
                b1 = (b1 + db);
            }
            this.limpiarColores();
            return this.image;
        }

        public Bitmap FiltroGamma()
        {
            float r, g, b;

            //Factor para gamma
            float rg = 1.1f;
            float gg = 1.5f;
            float bg = 0.9f;

            //Creaoms las rampas o tablas de cada color
            int[] rGamma = new int[256];
            int[] gGamma = new int[256];
            int[] bGamma = new int[256];

            for (int n = 0; n < 256; n++)
            {
                rGamma[n] = Math.Min(255, (int)((255.0 * Math.Pow(n / 255.0f, 1.0f / rg)) + 0.5f));
                gGamma[n] = Math.Min(255, (int)((255.0 * Math.Pow(n / 255.0f, 1.0f / gg)) + 0.5f));
                bGamma[n] = Math.Min(255, (int)((255.0 * Math.Pow(n / 255.0f, 1.0f / bg)) + 0.5f));
            }

            for (int x = 0; x < this.width; x++)
            {
                for (int y = 0; y < this.height; y++)
                {
                    this.oColor = this.image.GetPixel(x, y);

                    r = rGamma[this.oColor.R];
                    g = gGamma[this.oColor.G];
                    b = bGamma[this.oColor.B];

                    this.rColor = Color.FromArgb((int)r, (int)g, (int)b);

                    this.image.SetPixel(x, y, this.rColor);

                }
            }
            this.limpiarColores();
            return this.image;
        }

        public Bitmap FiltroRuido()
        {
            int porcentaje = 15;

            //0 a 200
            int rangoMin = 85;
            int rangoMax = 255;
            float pBrillo = 0;

            Random rnd = new Random();

            int r, g, b;

            for (int x = 0; x < this.width; x++)
            {
                for (int y = 0; y < this.height; y++)
                {
                    //Verificamos si el pixel tiene ruido o no
                    if (rnd.Next(1, 100) <= porcentaje)
                    {
                        //Metodo1
                        this.rColor = Color.FromArgb(rnd.Next(rangoMax, rangoMax),
                                                rnd.Next(rangoMin, rangoMax),
                                                rnd.Next(rangoMin, rangoMax));

                        //Metodo 2
                        pBrillo = rnd.Next(rangoMin, rangoMax) / 100.0f;
                        this.oColor = this.image.GetPixel(x, y);
                        r = (int)(this.oColor.R * pBrillo);
                        g = (int)(this.oColor.G * pBrillo);
                        b = (int)(this.oColor.B * pBrillo);

                        if (r > 255) r = 255;
                        else if (r < 0) r = 0;

                        if (g > 255) g = 255;
                        else if (g < 0) g = 0;

                        if (b > 255) b = 255;
                        else if (b < 0) b = 0;
                    }
                    else
                    {
                        this.rColor = this.image.GetPixel(x, y);
                    }

                    this.image.SetPixel(x, y, this.rColor);
                }
            }
            this.limpiarColores();
            return this.image;
        }

        //Barras
        public Bitmap FiltroContraste(int tbContraste)
        {
            int contraste;
            if (tbContraste == 5)
                contraste = 0;
            else
                contraste = (tbContraste - 5) * 20;

            float c = (100.0f + contraste) / 100.0f;
            c *= c;

            float r, g, b;

            for (int x = 0; x < this.width; x++)
                for (int y = 0; y < this.height; y++)
                {
                    //Obtenemos el color del pixel
                    this.oColor = this.image.GetPixel(x, y);

                    //Procesamos y obtenemos el nuevo color
                    r = ((((this.oColor.R / 255.0f) - 0.5f) * c) + 0.5f) * 255;
                    if (r > 255) r = 255;
                    if (r < 0) r = 0;

                    g = ((((this.oColor.G / 255.0f) - 0.5f) * c) + 0.5f) * 255;
                    if (g > 255) g = 255;
                    if (g < 0) g = 0;

                    b = ((((this.oColor.B / 255.0f) - 0.5f) * c) + 0.5f) * 255;
                    if (b > 255) b = 255;
                    if (b < 0) b = 0;

                    this.rColor = Color.FromArgb((int)r, (int)g, (int)b);

                    //Colocamos el color en resultante
                    this.image.SetPixel(x, y, rColor);
                }
            this.limpiarColores();
            return this.image;
        }

        public Bitmap FiltroBrillo(int tbBrillo)
        {
            int brillo;
            if (tbBrillo == 5)
                brillo = 0;
            else
                brillo = (tbBrillo - 5) * 51;

            float pBrillo = 1.2f;

            int r, g, b;

            for (int x = 0; x < this.width; x++)
            {
                for (int y = 0; y < this.height; y++)
                {
                    //Obtenemos el color del pixel
                    this.oColor = this.image.GetPixel(x, y);

                    //Procesamos y obtenemos el nuevo color

                    //Metodo1
                    r = this.oColor.R + brillo;
                    g = this.oColor.G + brillo;
                    b = this.oColor.B + brillo;

                    //Metodo2
                    /*
                    r = (int)(oColor.R * pBrillo);
                    g = (int)(oColor.G * pBrillo);
                    b = (int)(oColor.B * pBrillo);
                    */

                    if (r > 255) r = 255;
                    else if (r < 0) r = 0;

                    if (g > 255) g = 255;
                    else if (g < 0) g = 0;

                    if (b > 255) b = 255;
                    else if (b < 0) b = 0;

                    this.rColor = Color.FromArgb(r, g, b);

                    this.image.SetPixel(x, y, this.rColor);
                }
            }
            this.limpiarColores();
            return this.image;
        }
    }
}
