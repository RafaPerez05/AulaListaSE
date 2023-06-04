public class Lista{

    public No inicio;
    public No fim;

    public Lista(){
        this.inicio = null;
        this.fim = null;
    }

    public void inserirInicio(int Valor){
        //INSERIR UM ELEMENTO NO INICIO DA LISTA
        No novoNo = new(Valor);

        //INSERINDO EM UMA LISTA VAZIA
        if(this.inicio == null && this.fim == null){
            this.inicio = novoNo;
            this.fim = novoNo;
        }
        else if(this.inicio != null){ //LISTA NÃO VAZIA
            novoNo.noProx = this.inicio;
            this.inicio = novoNo;
        }
    }

public void inserirFim(int Valor)//inserir no fim da lista
    {
        No novoNO = new(Valor);

        if(this.inicio == null && this.fim == null){
            this.inicio = novoNO;
            this.fim = novoNO;
        }

        else if (this.fim.noProx == null){
            this.fim.noProx = novoNO;
            this.fim = novoNO;  
        }


    }
    public void removerInicio(){//REMOVER ELEMENTO NO INICIO DA LISTA
        if(this.inicio != null){
            this.inicio = this.inicio.noProx;
        }
        else{
            Console.Write("lista vazia");
        }
    }
    public void removerFim(){
    No noAtual = this.inicio;
    while (noAtual.noProx.noProx != null){
        noAtual = noAtual.noProx;
    }
    noAtual.noProx = null;
}

    public Boolean consulta(int Valor, ref No noAtual, ref No noAnterior){ 
        
        noAtual = this.inicio;
        noAnterior = null;

        while(noAtual != null){

            if(noAtual.valor == Valor){ //SE ENCONTROU O VALOR
                return(true);
            }
            noAnterior = noAtual;
            noAtual = noAtual.noProx;
        }
    
        return(false);
    }

    public void percurso(){
        
        No noAux = this.inicio;

        while(noAux != null){
            Console.Write(noAux.valor + " -> ");
            noAux = noAux.noProx;            
        }
    }
//estrutura do MENU







}