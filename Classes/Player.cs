namespace AulaPOO_PolimosrfismoSobreposicao.Classes
{
    public abstract class Player
    {
        private float velocidade;
        private float forcaPulo;

        public virtual string Correr(){
            return "Correndo em velocidade 1x";
        } 
    }
}