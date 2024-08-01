namespace DesignPatterns;

using System;
using System.Collections.Generic;

// Step 1: Define the Flyweight Interface
public interface ICharacter
{
    void Display(int position);
}

// Step 2: Create Concrete Flyweight
public class Character : ICharacter
{
    private readonly char _symbol;
    private readonly string _fontFamily;
    private readonly int _fontSize;

    public Character(char symbol, string fontFamily, int fontSize)
    {
        _symbol = symbol;
        _fontFamily = fontFamily;
        _fontSize = fontSize;
    }

    public void Display(int position)
    {
        Console.WriteLine($"Character: {_symbol}, Font: {_fontFamily}, Size: {_fontSize}, Position: {position}");
    }
}

// Step 3: Create Flyweight Factory
public class CharacterFactory
{
    private readonly Dictionary<string, Character> _characters = new Dictionary<string, Character>();

    public Character GetCharacter(char symbol, string fontFamily, int fontSize)
    {
        string key = $"{symbol}-{fontFamily}-{fontSize}";
        
        if (!_characters.ContainsKey(key))
        {
            _characters[key] = new Character(symbol, fontFamily, fontSize);
        }

        return _characters[key];
    }
}

// Step 4: Client Code
public class TextEditor
{
    private readonly CharacterFactory _characterFactory = new CharacterFactory();
    private readonly List<Tuple<ICharacter, int>> _characters = new List<Tuple<ICharacter, int>>();

    public void AddCharacter(char symbol, string fontFamily, int fontSize, int position)
    {
        var character = _characterFactory.GetCharacter(symbol, fontFamily, fontSize);
        _characters.Add(new Tuple<ICharacter, int>(character, position));
    }

    public void DisplayCharacters()
    {
        foreach (var character in _characters)
        {
            character.Item1.Display(character.Item2);
        }
    }
}

// Main Program
public class FlyweightSample
{
    public static void Usage(string[] args)
    {
        var editor = new TextEditor();

        // Add characters with different positions but the same formatting
        editor.AddCharacter('H', "Arial", 12, 0);
        editor.AddCharacter('e', "Arial", 12, 1);
        editor.AddCharacter('l', "Arial", 12, 2);
        editor.AddCharacter('l', "Arial", 12, 3);
        editor.AddCharacter('o', "Arial", 12, 4);

        // Add characters with different positions and different formatting
        editor.AddCharacter('W', "Times New Roman", 14, 5);
        editor.AddCharacter('o', "Times New Roman", 14, 6);
        editor.AddCharacter('r', "Times New Roman", 14, 7);
        editor.AddCharacter('l', "Times New Roman", 14, 8);
        editor.AddCharacter('d', "Times New Roman", 14, 9);

        // Display all characters
        editor.DisplayCharacters();
    }
}