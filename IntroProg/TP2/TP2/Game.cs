using System;

namespace TP2
{
  public class Game
  {
    #region Constants
    public const int HEART = 0;
    public const int DIAMOND = 1;
    public const int SPADE = 2;
    public const int CLUB = 3;

    public const int ACE = 0;
    public const int TWO = 1;
    public const int THREE = 2;
    public const int FOUR = 3;
    public const int FIVE = 4;
    public const int SIX = 5;
    public const int SEVEN = 6;
    public const int EIGHT = 7;
    public const int NINE = 8;
    public const int TEN = 9;
    public const int JACK = 10;
    public const int QUEEN = 11;
    public const int KING = 12;

    public const int NUM_SUITS = 4;
    public const int NUM_CARDS_PER_SUIT = 13;
    public const int NUM_CARDS = NUM_SUITS * NUM_CARDS_PER_SUIT;
    public const int NUM_CARDS_IN_HAND = 3;

    public const int FACES_SCORE = 10;
    public const int ACES_SCORE = 11;

    public const int MAX_SCORE = 31;
    public const int ALL_SAME_CARDS_VALUE_SCORE = 30;
    public const int ALL_FACES_SCORE = 30;
    public const int ONLY_FACES_SCORE = 28;
    public const int SAME_COLOR_SEQUENCE_SCORE = 28;
    public const int SEQUENCE_SCORE = 26;
    public const int SAME_COLOR_SCORE = 24;
    #endregion

    public static int GetSuitFromCardIndex(int index)
    {
      int suitFromCardIndex = index / NUM_CARDS_PER_SUIT;
      return suitFromCardIndex;
    }
    public static int GetValueFromCardIndex(int index)
    {
      int valueFromCardIndex = index % NUM_CARDS_PER_SUIT;
      return valueFromCardIndex;
    }
    public static void DrawFaces(int[] cardValues, bool[] selectedCards, bool[] availableCards)
    {
      int drawnCard = 0;
      Random random = new Random();
      for (int i = 0; i < cardValues.Length; i++)
      {
        if (!selectedCards[i])
        {
          do
          {
            drawnCard = random.Next(0, NUM_CARDS);
          } while (!availableCards[drawnCard]);
          cardValues[i] = drawnCard;
          availableCards[drawnCard] = false;
        }
      }
    }
    public static int GetScoreFromCardValue(int cardValue)
    {
      int scoreFromCardValue = 0;
      if (cardValue == ACE)
      {
        scoreFromCardValue = ACES_SCORE;
      }
      else if (cardValue >= TWO && cardValue <= TEN)
      {
        scoreFromCardValue = cardValue +1;
      }
      else if (cardValue == JACK || cardValue == QUEEN || cardValue == KING)
      {
        scoreFromCardValue = FACES_SCORE;
      }
      
      return scoreFromCardValue;
    }
    public static int GetHandScore(int[] cardIndexes)
    {
      int bestHandScore = 0;
      int specialCaseHandScore = 0;
      int suit = 0;
      int bestSuitHandScore = 0;
      int maxSuitHandScore = 0;

      int[] cardValues = new int[cardIndexes.Length];
      int[] cardSuits = new int[cardIndexes.Length];

      for (int i = 0; i < cardIndexes.Length; i++)
      {
        cardValues[i] = GetValueFromCardIndex(cardIndexes[i]);
        cardSuits[i] = GetSuitFromCardIndex(cardIndexes[i]);
      }
      while (suit < NUM_SUITS)
      {
        bestSuitHandScore = GetScoreFromMultipleCardsOfASuit(suit, cardValues, cardSuits);
        if (bestSuitHandScore > maxSuitHandScore)
        {
          maxSuitHandScore = bestSuitHandScore;
        }
        suit++;
      }
      if (HasAllSameCardValues(cardValues))
      {
        specialCaseHandScore = ALL_SAME_CARDS_VALUE_SCORE;
      }
      if (HasOnlyFaces(cardValues) && !HasSequence(cardValues))
      {
        specialCaseHandScore = ONLY_FACES_SCORE;
      }
      if (HasSameColorSequence(cardValues, cardSuits))
      {
        specialCaseHandScore = SAME_COLOR_SEQUENCE_SCORE;
      }
      if (HasSequence(cardValues))
      {
        specialCaseHandScore = SEQUENCE_SCORE;
      }
      if (HasOnlySameColorCards(cardSuits))
      {
        specialCaseHandScore = SAME_COLOR_SCORE;
      }
      if (specialCaseHandScore < maxSuitHandScore)
      {
        bestHandScore = maxSuitHandScore;
      }
      else
      {
        bestHandScore = specialCaseHandScore;
      }
      return bestHandScore;
    }
    public static void BubbleSort(int[] originalArray)
    {
      int swapCount;
      do
      {
        swapCount = 0;
        for (int i = 0; i < originalArray.Length - 1; i++)
        {
          if (originalArray[i] > originalArray[i + 1])
          {
            int temp = originalArray[i];
            originalArray[i] = originalArray[i + 1];
            originalArray[i + 1] = temp;
            swapCount++;
          }
        }
      } while (swapCount > 0);
    }
    //public static int GetHighestCardValue(int[] cardValues)
    //{
    //  int highestCardValue = 0;
    //  for (int i = 0; i < cardValues.Length - 1; i++)
    //  {
    //    if (cardValues[i] == ACE)
    //    {
    //      return ACE;
    //    }
    //    else if (cardValues[i] >= cardValues[i + 1])
    //    {
    //      highestCardValue = cardValues[i];
    //    }
    //  }
    //  return highestCardValue;
    //}
    public static bool HasOnlySameColorCards(int[] suits)
    {
      bool isSuitRed = false;
      if ((suits[0] == HEART) || (suits[0] == DIAMOND))
      {
        isSuitRed = true;
      }
      for (int i = 0; i < suits.Length; i++)
      {
        if ((isSuitRed && (suits[i] != HEART && suits[i] != DIAMOND)) || (!isSuitRed && (suits[i] != SPADE && suits[i] != CLUB)))
        {
          return false;
        }
      }
      return true;
    }
    public static bool HasAllSameCardValues(int[] values)
    {
      for (int i = 1; i < values.Length; i++)
      {
        if (values[i] != values[0])
        {
          return false;
        }
      }
      return true;
    }
    public static bool HasAllFaces(int[] values)
    {
      if (HasSequence(values))
      {
        for (int i = 0; i < values.Length; i++)
        {
          if (values[i] == KING)
          {
            return true;
          }
        }
      }
      return false;
    }
    public static bool HasSequence(int[] values)
    {
      int[] TempSortedValuesArray = new int[values.Length];
      for (int i = 0; i < values.Length; i++)
      {
        TempSortedValuesArray[i] = values[i];
      }
      for (int i = 1; i < TempSortedValuesArray.Length; i++)
      {
        BubbleSort(TempSortedValuesArray);
        if (TempSortedValuesArray[i - 1] != TempSortedValuesArray[i] - 1)
        {
          return false;
        }
      }
      return true;
    }
    public static bool HasOnlyFaces(int[] values)
    {
      int cardFacesCount = 0;
      for (int i = 0; i < values.Length; i++)
      {
        if (values[i] >= JACK)
        {
          cardFacesCount++;
        }
      }
      if (cardFacesCount != values.Length)
      {
        return false;
      }
      return true;
    }
    public static bool HasSameColorSequence(int[] values, int[] suits)
    {
      if (HasSequence(values) && HasOnlySameColorCards(suits))
      {
        return true;
      }
      return false;
    }
    public static int GetScoreFromMultipleCardsOfASuit(int suit, int[] values, int[] suits)
    {
      int cardsTotalScore = 0;
      for (int i = 0; i < suits.Length; i++)
      {
        if (suits[i] == suit)
        {
          cardsTotalScore += GetScoreFromCardValue(values[i]);
        }
      }
      return cardsTotalScore;
    }
    public static void ShowScore(int[] cardIndexes)
    {
      int hand = GetHandScore(cardIndexes);
      Display.WriteString($"Votre score est de : {hand}", 0, Display.CARD_HEIGHT + 14, ConsoleColor.Black);
    }
  }
}
