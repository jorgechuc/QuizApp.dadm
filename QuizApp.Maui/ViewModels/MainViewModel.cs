using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using QuizApp.Maui.Models;

namespace QuizApp.Maui.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _textoDeLaPregunta;
        [ObservableProperty]
        private string _resultado;

        private BancoDePreguntas _preguntas;
        private Pregunta _preguntaActual;

        public MainViewModel()
        {
            _preguntas = new BancoDePreguntas();
            _preguntaActual = _preguntas.ObtenerPrimerElemento();
            TextoDeLaPregunta = _preguntaActual.Texto;
            Resultado = string.Empty;
        }

        [RelayCommand]
        private void PreguntaSiguiente()
        {
            _preguntaActual = _preguntas.ObtenerElementoSiguiente();
            TextoDeLaPregunta = _preguntaActual.Texto;
            Resultado = string.Empty;
        }

        [RelayCommand]
        private void PreguntaAnterior()
        {
            _preguntaActual = _preguntas.ObtenerElementoAnterior();
            TextoDeLaPregunta = _preguntaActual.Texto;
            Resultado = string.Empty;
        }

        [RelayCommand]
        private void VerificaRespuestaEsCierto()
        {
            VerificaRespuesta(true);
        }

        [RelayCommand]
        private void VerificaRespuestaEsFalso()
        {
            VerificaRespuesta(false);
        }

        private void VerificaRespuesta(bool boton)
        {
            if (boton == _preguntaActual.RespuestaEsCierto)
            {
                Resultado = "¡¡Correcto!!";
            }
            else
            {
                Resultado = "¡¡Incorrecto!!";
            }
        }
    }
}
