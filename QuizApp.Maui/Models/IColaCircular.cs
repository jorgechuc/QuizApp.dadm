namespace QuizApp.Maui.Models
{
    public interface IColaCircular
    {
        Pregunta ObtenerPrimerElemento();
        Pregunta ObtenerElementoSiguiente();
        Pregunta ObtenerElementoAnterior();
    }
}
