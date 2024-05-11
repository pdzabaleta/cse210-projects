using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private  int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;

    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        // Verifica si es un solo versículo o un rango de versículos
        if (_endVerse == 0)
        {
            // Devuelve la referencia en el formato "Libro Capítulo:Versículo"
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            // Devuelve la referencia en el formato "Libro Capítulo:Versículo-InicioVersículo"
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }
    }

}