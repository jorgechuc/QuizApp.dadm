namespace QuizApp.Maui.Models
{
    public class BancoDePreguntas : IColaCircular
    {
        private IList<Pregunta> _preguntas;
        private int _indiceDePreguntaActual;

        public BancoDePreguntas()
        {
            _preguntas = CargarPreguntas();
            _indiceDePreguntaActual = 0;
        }

        private List<Pregunta> CargarPreguntas()
        {
            var preguntas = new List<Pregunta>();
            preguntas.Add(
                new Pregunta
                {
                    Texto = "¿La península de Yucatán se encuentra al norte de México?",
                    RespuestaEsCierto = false
                });
            preguntas.Add(
                new Pregunta
                {
                    Texto = "¿Nuestro sistema solar se encuentra en la galaxia Vía Láctea?",
                    RespuestaEsCierto = true
                });
            preguntas.Add(
                new Pregunta
                {
                    Texto = "¿El oceáno más grande de nuestro planeta es el Oceáno Pacífico?",
                    RespuestaEsCierto = true
                });
            preguntas.Add(
                new Pregunta
                {
                    Texto = "¿El estado más grande de la República Mexicana es Sonora?",
                    RespuestaEsCierto = false
                });
            preguntas.Add(
                new Pregunta
                {
                    Texto = "¿Los vientos alisios soplan del noreste al suroeste?",
                    RespuestaEsCierto = true
                });
            return preguntas;
        }


        public Pregunta ObtenerElementoAnterior()
        {
            if (_indiceDePreguntaActual > 0)
            {
                _indiceDePreguntaActual--;
            }
            else
            {
                _indiceDePreguntaActual = _preguntas.Count - 1;
            }
            return _preguntas[_indiceDePreguntaActual];
        }

        public Pregunta ObtenerElementoSiguiente()
        {
            if (_indiceDePreguntaActual < _preguntas.Count - 1)
            {
                _indiceDePreguntaActual++;
            }
            else
            {
                _indiceDePreguntaActual = 0;
            }
            return _preguntas[_indiceDePreguntaActual];
        }

        public Pregunta ObtenerPrimerElemento()
        {
            _indiceDePreguntaActual = 0;
            return _preguntas[_indiceDePreguntaActual];
        }
    }
}
