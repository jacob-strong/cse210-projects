using System;

class Program
{
    static void Main(string[] args)
    {
        GenerateDeck();
        ShuffleList(MainDeck);

        int count = 7;
        while(count >= 0){
            moveCard(MainDeck, Player1);
            count --;
        }

        count = 7;
        while(count >= 0){
            moveCard(MainDeck, Player2);
            count --;
        }

        Console.WriteLine("Main Deck - ");
        foreach(Card i in MainDeck){
            i.display();
        }
        Console.WriteLine();

        Console.WriteLine("PLayer 1's Starting Hand - ");
        foreach(Card i in Player1){
            i.display();
        }
        Console.WriteLine();

        Console.WriteLine("Player 2's Starting Hand - ");
        foreach(Card i in Player2){
            i.display();
        }
    }

    static List<Card> MainDeck = new List<Card>();
    static List<Card> Discard = new List<Card>();
    static List<Card> Player1 = new List<Card>();
    static List<Card> Player2 = new List<Card>();

    static void GenerateDeck(){
        BasicCard red01 = new BasicCard("red", 0);
        MainDeck.Add(red01);
        BasicCard red11 = new BasicCard("red", 1);
        MainDeck.Add(red11);
        BasicCard red21 = new BasicCard("red", 2);
        MainDeck.Add(red21);
        BasicCard red31 = new BasicCard("red", 3);
        MainDeck.Add(red31);
        BasicCard red41 = new BasicCard("red", 4);
        MainDeck.Add(red41);
        BasicCard red51 = new BasicCard("red", 5);
        MainDeck.Add(red51);

        BasicCard blue01 = new BasicCard("blue", 0);
        MainDeck.Add(blue01);
        BasicCard blue11 = new BasicCard("blue", 1);
        MainDeck.Add(blue11);
        BasicCard blue21 = new BasicCard("blue", 2);
        MainDeck.Add(blue21);
        BasicCard blue31 = new BasicCard("blue", 3);
        MainDeck.Add(blue31);
        BasicCard blue41 = new BasicCard("blue", 4);
        MainDeck.Add(blue41);
        BasicCard blue51 = new BasicCard("blue", 5);
        MainDeck.Add(blue51);

        BasicCard yellow01 = new BasicCard("yellow", 0);
        MainDeck.Add(yellow01);
        BasicCard yellow11 = new BasicCard("yellow", 1);
        MainDeck.Add(yellow11);
        BasicCard yellow21 = new BasicCard("yellow", 2);
        MainDeck.Add(yellow21);
        BasicCard yellow31 = new BasicCard("yellow", 3);
        MainDeck.Add(yellow31);
        BasicCard yellow41 = new BasicCard("yellow", 4);
        MainDeck.Add(yellow41);
        BasicCard yellow51 = new BasicCard("yellow", 5);
        MainDeck.Add(yellow51);

        BasicCard green01 = new BasicCard("green", 0);
        MainDeck.Add(green01);
        BasicCard green11 = new BasicCard("green", 1);
        MainDeck.Add(green11);
        BasicCard green21 = new BasicCard("green", 2);
        MainDeck.Add(green21);
        BasicCard green31 = new BasicCard("green", 3);
        MainDeck.Add(green31);
        BasicCard green41 = new BasicCard("green", 4);
        MainDeck.Add(green41);
        BasicCard green51 = new BasicCard("green", 5);
        MainDeck.Add(green51);

    }

    static void ShuffleList(List<Card> list){
        Random rng = new Random();
        int n = list.Count;
        while(n > 1){
            n--;
            int k = rng.Next(n + 1);
            Card temp = list[k];
            list[k] = list[n];
            list[n] = temp;
        }
    }

    static void moveCard(List<Card> from, List<Card> to){
        to.Add(from[0]);
        from.RemoveAt(0);
    }
}