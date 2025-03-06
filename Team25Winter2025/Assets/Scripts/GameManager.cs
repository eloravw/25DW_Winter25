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

    //Seance Room 1 Clues
    public static bool clueC { get; set; }
    public static bool clueF { get; set; }

    //Seance Room 2 Clues
    public static bool clueO { get; set; }
    public static bool clueX { get; set; }

    //Music Room Clues
    public static bool clueK { get; set; }
    public static bool clueL { get; set; }

    //Entrance
    public static bool clueM { get; set; }
    public static bool clueP { get; set; }

    //Library
    public static bool clueN { get; set; }
    public static bool clueR { get; set; }

    //Yard
    public static bool clueV { get; set; }
    public static bool clueS { get; set; }

    //Beach
    public static bool clueI { get; set; }
    public static bool clueA { get; set; }
    public static bool clueJ { get; set; }

    //Cave
    public static bool clueZ { get; set; }
    public static bool clueT { get; set; }
    public static bool clueD { get; set; }

    //Mountain
    public static bool clueE { get; set; }
    public static bool clueB { get; set; }



}
