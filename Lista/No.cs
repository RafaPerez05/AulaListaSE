public class No{

    //Atributos
    public int valor;
    public No noProx;

    //Construtor
    public No(int Valor){
        this.valor = Valor;
        this.noProx = null;
    }

    //Métodos
    public void imprimir(){
            Console.WriteLine("Valor: " + this.valor);
    }

}