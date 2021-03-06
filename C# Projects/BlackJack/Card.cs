﻿using System;
using static System.Console;

using static Blackjack.Suit;
using static Blackjack.Face;

namespace Blackjack
{
    public enum Suit
    {
        Clubs,
        Spades,
        Diamonds,
        Hearts
    }
    public enum Face
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    public class Card
    {
        public Suit Suit { get; }
        public Face Face { get; }
        public int Value { get; set; }
        public char Symbol { get; }

        // Declaring Value and Suit Symbol
        public Card(Suit suit, Face face)
        {
            Suit = suit;
            Face = face;

            switch (Suit)
            {
                case Clubs:
                    Symbol = '♣';
                    break;

                case Spades:
                    Symbol = '♠';
                    break;

                case Diamonds:
                    Symbol = '♦';
                    break;

                case Hearts:
                    Symbol = '♥';
                    break;

            }
            switch (Face)
            {
                case Ten:
                case Jack:
                case Queen:
                case King:
                    Value = 10;
                    break;

                case Ace:
                    Value = 11;
                    break;

                default:
                    Value = (int)Face + 1;
                    break;
            }
        }

        // Marks which cards are drawn and what color. 
        public void WriteDescription()
        {
            if (Suit == Suit.Diamonds || Suit == Suit.Hearts)
            {
                ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                ForegroundColor = ConsoleColor.White;
            }

            if (Face == Ace)
            {
                if (Value == 11)
                {
                    WriteLine(Symbol + " Soft " + Face + " of " + Suit);
                }
                else
                {
                    WriteLine(Symbol + " Hard " + Face + " of " + Suit);
                }
            }
            else
            {
                WriteLine(Symbol + " " + Face + " of " + Suit);
            }
            Casino.ColorReset();
        }
    }
}