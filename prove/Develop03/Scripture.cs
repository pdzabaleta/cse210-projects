using System;

public class Scripture
{
    private Reference _reference;
    private  List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        // Split the text into words
        string[] wordsArray = text.Split(' ');

        // Create a Word object for each word and add it to the list
        foreach (string wordText in wordsArray)
        {
            Word word = new Word(wordText);
            _words.Add(word);
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        // set the state of a randomly selected group of words to be hidden
        // need yo find  a set  of visible words
        // need  to randomly select  'numbertohidde' of those words
        // use hide function
        Random random = new Random();

        // Contador para el número de palabras ocultadas
        int hiddenCount = 0;

        // Ocultar el número especificado de palabras aleatorias
        while (hiddenCount < numberToHide)
        {
        // Seleccionar aleatoriamente una palabra
        int randomIndex = random.Next(0, _words.Count);
        Word word = _words[randomIndex];

        // Verificar si la palabra está visible antes de ocultarla
        if (!word.IsHidden())
        {
            // Ocultar la palabra
            word.Hide();
            hiddenCount++;
        }
        }
    }
        public string GetDisplayText()
    {
        // Construir el texto de la escritura incluyendo la referencia y todas las palabras visibles
        string displayText = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            // Usar el método GetDisplayText de la clase Word para obtener el texto de la palabra
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }

        public bool IsCompletelyHidden()
    {
        // Verificar si todas las palabras están ocultas
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}