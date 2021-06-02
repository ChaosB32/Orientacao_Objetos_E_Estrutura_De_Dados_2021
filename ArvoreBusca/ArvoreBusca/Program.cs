using System;

namespace ArvoreBusca
{
    class Program
    {
        public class Nodo
        {
            public int Info;
            public Nodo esquerdo;
            public Nodo direito;

            public void imprimeNodo()
            {
                Console.Write(Info + " ");
            }
        }

        public class ArvoreBinaria
        {
            public Nodo raiz;
            public ArvoreBinaria()
            {
                raiz = null;
            }
            public void insereInfo(int i)
            {
                Nodo novoNodo = new Nodo();
                novoNodo.Info = i;
                if (raiz == null)
                {
                    raiz = novoNodo;
                }
                else
                {
                    Nodo corrente = raiz;
                    Nodo pai;
                    while (true)
                    {
                        pai = corrente;
                        if (i < corrente.Info)
                        {  //procurando a subárvore à esquerda
                            corrente = corrente.esquerdo;
                            if (corrente == null)
                            {
                                pai.esquerdo = novoNodo;
                                break;
                            }
                        }
                        else
                        {  //procurando a subárvore à direita
                            corrente = corrente.direito;
                            if (corrente == null)
                            {
                                pai.direito = novoNodo;
                                break;
                            }
                        }
                    }
                }
            }


            public void preOrdem(Nodo aRaiz)
            {
                if (aRaiz != null)
                {
                    aRaiz.imprimeNodo();
                    preOrdem(aRaiz.esquerdo);
                    preOrdem(aRaiz.direito);
                }
            }

            public void posOrdem(Nodo aRaiz)
            {
                if (aRaiz != null)
                {
                    posOrdem(aRaiz.esquerdo);
                    posOrdem(aRaiz.direito);
                    aRaiz.imprimeNodo();
                }
            }


            public void inOrdem(Nodo aRaiz)
            {
                if (aRaiz != null)
                {
                    inOrdem(aRaiz.esquerdo);
                    aRaiz.imprimeNodo();
                    inOrdem(aRaiz.direito);
                }
            }

            public int achaMinimo()
            {
                Nodo corrente = raiz;
                while (!(corrente.esquerdo == null))
                {
                    corrente = corrente.esquerdo;
                }
                return corrente.Info;
            }

            public int achaMaximo()
            {
                Nodo corrente = raiz;
                while (!(corrente.direito == null))
                {
                    corrente = corrente.direito;
                }
                return corrente.Info;
            }

            public Nodo achaInfo(int key)
            {
                Nodo corrente = raiz;
                while (corrente.Info != key)
                {
                    if (key < corrente.Info)
                    {
                        corrente = corrente.esquerdo;
                    }
                    else
                    {
                        corrente = corrente.direito;
                    }
                    if (corrente == null)
                    {
                        return null;
                    }
                }
                return corrente;
            }


            public bool excluir(int key)
            {
                Nodo corrente = raiz;
                Nodo pai = raiz;
                bool ehFilhoEsquerdo = true;
                while (corrente.Info != key)
                {
                    pai = corrente;
                    if (key < corrente.Info)
                    {
                        ehFilhoEsquerdo = true;
                        corrente = corrente.direito;
                    }
                    else
                    {
                        ehFilhoEsquerdo = false;
                        corrente = corrente.direito;
                    }
                    if (corrente == null)
                    {
                        return false;
                    }
                }
                if ((corrente.esquerdo == null) && (corrente.direito == null))
                {
                    if (corrente == raiz)
                    {
                        raiz = null;
                    }
                    else if (ehFilhoEsquerdo)
                    {
                        pai.esquerdo = null;
                    }
                    else
                    {
                        pai.direito = null;
                    }
                }
                //apagando um nodo com um filho
                else if (corrente.direito == null)
                {
                    if (corrente == raiz)
                    {
                        raiz = corrente.esquerdo;
                    }
                    else if (ehFilhoEsquerdo)
                    {
                        pai.esquerdo = corrente.esquerdo;
                    }
                    else
                    {
                        pai.direito = corrente.direito;
                    }
                }
                else if (corrente.esquerdo == null)
                {
                    if (corrente == raiz)
                    {
                        raiz = corrente.direito;
                    }
                    else if (ehFilhoEsquerdo)
                    {
                        pai.esquerdo = pai.direito;
                    }
                    else
                    {
                        pai.direito = corrente.direito;
                    }
                }
                //apagando um nodo com dois filhos
                else
                {
                    Nodo sucessor = getSucessor(corrente);
                    if (corrente == raiz)
                    {
                        raiz = sucessor;
                    }
                    else if (ehFilhoEsquerdo)
                    {
                        pai.esquerdo = sucessor;
                    }
                    else
                    {
                        pai.direito = sucessor;
                    }
                    sucessor.esquerdo = corrente.esquerdo;
                }
                return true;
            }


            public Nodo getSucessor(Nodo delNodo)
            {
                Nodo sucessorPai = delNodo;
                Nodo sucessor = delNodo;
                Nodo corrente = delNodo.direito;
                while (!(corrente == null))
                {
                    sucessorPai = corrente;
                    sucessor = corrente;
                    corrente = corrente.esquerdo;
                }
                if (!(sucessor == delNodo.direito))
                {
                    sucessorPai.esquerdo = sucessor.direito;
                    sucessor.direito = delNodo.direito;
                }
                return sucessor;
            }
        }


        public static void Main(string[] args)
        {
            ArvoreBinaria numeros = new ArvoreBinaria();

            numeros.insereInfo(20);
            numeros.insereInfo(10);
            numeros.insereInfo(40);
            numeros.insereInfo(5);
            numeros.insereInfo(15);
            numeros.insereInfo(3);
            numeros.insereInfo(7);
            numeros.insereInfo(12);
            numeros.insereInfo(17);
            numeros.insereInfo(30);
            numeros.insereInfo(50);
            numeros.insereInfo(45);
            numeros.insereInfo(55);


            Console.WriteLine("\n\n\nBusca em profundidade: PRE-ORDEM: ");
            numeros.preOrdem(numeros.raiz);

            Console.WriteLine("\n\n\nBusca em profundidade: POS-ORDEM: ");
            numeros.posOrdem(numeros.raiz);

            Console.WriteLine("\n\n\nBusca em profundidade: IN-ORDEM: ");
            numeros.inOrdem(numeros.raiz);


            /*            
            numeros.insereInfo(20);
            numeros.insereInfo(15);
            numeros.insereInfo(12);
            numeros.insereInfo(30);
            numeros.insereInfo(25);
            numeros.insereInfo(35);
            numeros.insereInfo(40);
            */


            /*primeira árvore*/
            /*
            numeros.insereInfo(23);
            numeros.insereInfo(45);
            numeros.insereInfo(16);
            numeros.insereInfo(37);
            numeros.insereInfo(3);
            numeros.insereInfo(99);
            numeros.insereInfo(22);
            numeros.insereInfo(19);
            numeros.insereInfo(24);
            numeros.insereInfo(28);
            */

            /* segunda árvore */
            /*numeros.insereInfo(40);
            numeros.insereInfo(30);
            numeros.insereInfo(15);
            numeros.insereInfo(12);
            numeros.insereInfo(20);
            numeros.insereInfo(50);
            numeros.insereInfo(45);
            numeros.insereInfo(70);
            numeros.insereInfo(62);
            numeros.insereInfo(78);*/

            /*Terceira árvore */
            /*numeros.insereInfo(100);
            numeros.insereInfo(50);
            numeros.insereInfo(25);
            numeros.insereInfo(12);
            numeros.insereInfo(7);
            numeros.insereInfo(35);
            numeros.insereInfo(40);
            numeros.insereInfo(75);
            numeros.insereInfo(85);
            numeros.insereInfo(150);
            numeros.insereInfo(170);*/




            Console.ReadKey();
        }
    }
}
