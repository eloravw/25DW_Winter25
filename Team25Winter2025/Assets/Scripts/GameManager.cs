using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameManager
{
    //Ouiji Board Puzzle Pieces
    public static bool ouijaLampCollected { get; set; }
    public static bool ouijaCloakCollected { get; set; }
    public static bool ouijaCandleCollected { get; set; }

    //Music Room Puzzle Solved
    public static bool solvedMusicRoom { get; set; }

    //Candle Puzzle Solved
    public static bool solvedCandlePuzzle { get; set; }

    //Painting Puzzle Solved
    public static bool solvedPaintingPuzzle { get; set; }

    //Clues

    //Big Translation Clue
    public static bool TranslationClue { get; set; }

    //Seance Room Clues
    public static bool clueC { get; set; }
    public static bool clueI { get; set; }
    public static bool clueO { get; set; }

    //Music Room Clues
    public static bool clueE { get; set; }
    public static bool clueB { get; set; }

    //Entrance
    public static bool clueU { get; set; }
    public static bool clueG { get; set; }

    //Library
    public static bool clueW { get; set; }

    //Cave
    public static bool clueN { get; set; }
    public static bool clueT { get; set; }

}
