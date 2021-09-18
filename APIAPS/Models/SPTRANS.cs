using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIAPS.Models
{
    public class SPTRANS
    {
        public class autenticar
        {
            public bool autenticado { get; set; }

        }
        public class Buscar
        {

            public class Linhas
            {
                public int cl { get; set; }
                public bool lc { get; set; }
                public string lt { get; set; }
                public int sl { get; set; }
                public int tl { get; set; }
                public string tp { get; set; }
                public string ts { get; set; }
            }

            public class Paradas
            {
                public int cp { get; set; }
                public string np { get; set; }
                public string ed { get; set; }
                public double py { get; set; }
                public double px { get; set; }
            }


        }
        public class Corredores
        {
            public int cc { get; set; }
            public string nc { get; set; }
        }
        public class Empresa
        {
            public class E2
            {
                public int a { get; set; }
                public int c { get; set; }
                public string n { get; set; }
            }

            public class E
            {
                public int a { get; set; }
                public List<E2> e { get; set; }
            }
            public string hr { get; set; }
            public List<E> e { get; set; }
        }
        public class Posicao
        {

            public class PosicaoSemLinha
            {
                public class V
                {
                    public int p { get; set; }
                    public bool a { get; set; }
                    public DateTime ta { get; set; }
                    public double py { get; set; }
                    public double px { get; set; }
                }

                public class L
                {
                    public string c { get; set; }
                    public int cl { get; set; }
                    public int sl { get; set; }
                    public string lt0 { get; set; }
                    public string lt1 { get; set; }
                    public int qv { get; set; }
                    public List<V> vs { get; set; }
                }
                public string hr { get; set; }
                public List<L> l { get; set; }
            }
            public class PosicaoComLinha
            {
                public class V
                {
                    public string p { get; set; }
                    public bool a { get; set; }
                    public DateTime ta { get; set; }
                    public double py { get; set; }
                    public double px { get; set; }
                }


                public string hr { get; set; }
                public List<V> vs { get; set; }

            }
            public class PosicaoGaragem
            {
                public class V
                {
                    public int p { get; set; }
                    public bool a { get; set; }
                    public DateTime ta { get; set; }
                    public double py { get; set; }
                    public double px { get; set; }
                }

                public class L
                {
                    public string c { get; set; }
                    public int cl { get; set; }
                    public int sl { get; set; }
                    public string lt0 { get; set; }
                    public string lt1 { get; set; }
                    public int qv { get; set; }
                    public List<V> vs { get; set; }
                }

                public string hr { get; set; }
                public List<L> l { get; set; }
            }

        }
        public class Previsao
        {
            public class PrevisaoCodigoParada
            {
                public class V
                {
                    public string p { get; set; }
                    public string t { get; set; }
                    public bool a { get; set; }
                    public DateTime ta { get; set; }
                    public double py { get; set; }
                    public double px { get; set; }
                }

                public class L
                {
                    public string c { get; set; }
                    public int cl { get; set; }
                    public int sl { get; set; }
                    public string lt0 { get; set; }
                    public string lt1 { get; set; }
                    public int qv { get; set; }
                    public List<V> vs { get; set; }
                }

                public class P
                {
                    public int cp { get; set; }
                    public string np { get; set; }
                    public double py { get; set; }
                    public double px { get; set; }
                    public List<L> l { get; set; }
                }

                public string hr { get; set; }
                public P p { get; set; }
            }
            public class PrevisaoCodigoLinha
            {

                public class V
                {
                    public string p { get; set; }
                    public string t { get; set; }
                    public bool a { get; set; }
                    public DateTime ta { get; set; }
                    public double py { get; set; }
                    public double px { get; set; }
                }

                public class P
                {
                    public int cp { get; set; }
                    public string np { get; set; }
                    public double py { get; set; }
                    public double px { get; set; }
                    public List<V> vs { get; set; }
                }

                public class Root
                {
                    public string hr { get; set; }
                    public List<P> ps { get; set; }
                }

            }
            public class PrevisaoParada
            {
                public class V
                {
                    public string p { get; set; }
                    public string t { get; set; }
                    public bool a { get; set; }
                    public DateTime ta { get; set; }
                    public double py { get; set; }
                    public double px { get; set; }
                }

                public class L
                {
                    public string c { get; set; }
                    public int cl { get; set; }
                    public int sl { get; set; }
                    public string lt0 { get; set; }
                    public string lt1 { get; set; }
                    public int qv { get; set; }
                    public List<V> vs { get; set; }
                }

                public class P
                {
                    public int cp { get; set; }
                    public string np { get; set; }
                    public double py { get; set; }
                    public double px { get; set; }
                    public List<L> l { get; set; }
                }

                public string hr { get; set; }
                public P p { get; set; }
            }
        }

        public class Arquivos
        {
            //pegar arquivos?

        }
    }
    
}