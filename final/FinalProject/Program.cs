//Jacob Strong, with help from stack overflow for the shuffle function
using System;

class Program
{
    static void Main(string[] args)
    {
        startGame();
        string player1Ability = null;
        string player2Ability = null;

        while(Player1.Count() != 0 && Player2.Count() != 0){
            //Player 1's turn
            Console.Clear();
            Console.WriteLine("Player 1, it's your turn!");
            startTurn(Player1, 1);
            if(player2Ability == "skip"){
                Console.WriteLine("You were skipped!");
                player2Ability = null;
                loadTime();
            }
            else if(player2Ability == "plus2"){
                Console.WriteLine("Draw 2 cards :(");
                moveCard(mainDeck, mainDeck.Count()-1, Player1);
                Console.WriteLine("You drew a "+Player1[Player1.Count()-1].display());
                moveCard(mainDeck, mainDeck.Count()-1, Player1);
                Console.WriteLine("You drew a "+Player1[Player1.Count()-1].display());
                player2Ability = null;
                loadTime();
            }
            else if(player2Ability == "plus4"){
                Console.WriteLine("Draw 4 cards :(");
                moveCard(mainDeck, mainDeck.Count()-1, Player1);
                Console.WriteLine("You drew a "+Player1[Player1.Count()-1].display());
                moveCard(mainDeck, mainDeck.Count()-1, Player1);
                Console.WriteLine("You drew a "+Player1[Player1.Count()-1].display());
                moveCard(mainDeck, mainDeck.Count()-1, Player1);
                Console.WriteLine("You drew a "+Player1[Player1.Count()-1].display());
                moveCard(mainDeck, mainDeck.Count()-1, Player1);
                Console.WriteLine("You drew a "+Player1[Player1.Count()-1].display());
                player2Ability = null;
                loadTime();
            }
            else{
                bool played = false;
                while(played == false){
                    Console.WriteLine("Choose a card to play (type 'cant' if you can't play a card) - ");
                    string cardChoice = Console.ReadLine();
                    bool parseYes = int.TryParse(cardChoice, out int choiceNum);
                    if(cardChoice == "cant"){
                        Console.WriteLine("You have to draw then :(");
                        moveCard(mainDeck, mainDeck.Count()-1, Player1);
                        Console.WriteLine("You drew a "+Player1[Player1.Count()-1].display());
                        played = true;
                        loadTime();
                    }
                    else if((parseYes && (choiceNum < 1 || choiceNum > Player1.Count())) || !parseYes){
                        Console.WriteLine("That isn't a card that works, try again");
                        continue;
                    }
                    else{
                        if(Player1[choiceNum-1].getColor() == Discard[Discard.Count()-1].getColor() || Player1[choiceNum-1].getColor() == "black" || Discard[Discard.Count()-1].getColor() == "black" || Player1[choiceNum-1].getIcon() == Discard[Discard.Count()-1].getIcon()){
                            Console.Write("You played ");
                            Console.WriteLine(Player1[choiceNum-1].display());
                            if(Player1[choiceNum-1].getColor() == "black"){
                                Console.WriteLine("You played a wild card, what would you like the new color to be?");
                                string colorChoice = Console.ReadLine();
                                Player1[choiceNum-1].setColor(colorChoice);
                            }
                            if(Player1[choiceNum-1].getAbility() == "skip"){
                                player1Ability = "skip";
                            }
                            if(Player1[choiceNum-1].getAbility() == "wild"){
                                player1Ability = "wild";
                            }
                            if(Player1[choiceNum-1].getAbility() == "plus2"){
                                player1Ability = "plus2";
                            }
                            if(Player1[choiceNum-1].getAbility() == "plus4"){
                                player1Ability = "plus4";
                            }
                            moveCard(Player1, choiceNum-1, Discard);
                            played = true;
                            loadTime();
                        }
                        else {
                            Console.WriteLine("That card doesn't work, try again :(");
                        }
                    }
                }
            }
            if(Player1.Count() == 0){
                Console.WriteLine("Player 1 won!");
                continue;
            }

            //Player 2's turn
            Console.Clear();
            Console.WriteLine("Player 2, it's your turn!");
            startTurn(Player2, 2);
            if(player1Ability == "skip"){
                Console.WriteLine("You were skipped!");
                player1Ability = null;
                loadTime();
            }
            else if(player1Ability == "plus2"){
                Console.WriteLine("Draw 2 cards :(");
                moveCard(mainDeck, mainDeck.Count()-1, Player2);
                Console.WriteLine("You drew a "+Player2[Player2.Count()-1].display());
                moveCard(mainDeck, mainDeck.Count()-1, Player2);
                Console.WriteLine("You drew a "+Player2[Player2.Count()-1].display());
                player1Ability = null;
                loadTime();
            }
            else if(player1Ability == "plus4"){
                Console.WriteLine("Draw 4 cards :(");
                moveCard(mainDeck, mainDeck.Count()-1, Player2);
                Console.WriteLine("You drew a "+Player2[Player2.Count()-1].display());
                moveCard(mainDeck, mainDeck.Count()-1, Player2);
                Console.WriteLine("You drew a "+Player2[Player2.Count()-1].display());
                moveCard(mainDeck, mainDeck.Count()-1, Player2);
                Console.WriteLine("You drew a "+Player2[Player2.Count()-1].display());
                moveCard(mainDeck, mainDeck.Count()-1, Player2);
                Console.WriteLine("You drew a "+Player2[Player2.Count()-1].display());
                player1Ability = null;
                loadTime();
            }
            else{
                bool played = false;
                while(played == false){
                    Console.WriteLine("Choose a card to play (type 'cant' if you can't play a card) - ");
                    string cardChoice = Console.ReadLine();
                    bool parseYes = int.TryParse(cardChoice, out int choiceNum);
                    if(cardChoice == "cant"){
                        Console.WriteLine("You have to draw then :(");
                        moveCard(mainDeck, mainDeck.Count()-1, Player2);
                        Console.WriteLine("You drew a "+Player2[Player2.Count()-1].display());
                        played = true;
                        loadTime();
                    }
                    else if((parseYes && (choiceNum < 1 || choiceNum > Player1.Count())) || !parseYes){
                        Console.WriteLine("That isn't a card that works, try again");
                        continue;
                    }
                    else{
                        if(Player2[choiceNum-1].getColor() == Discard[Discard.Count()-1].getColor() || Player2[choiceNum-1].getColor() == "black" || Discard[Discard.Count()-1].getColor() == "black" || Player2[choiceNum-1].getIcon() == Discard[Discard.Count()-1].getIcon()){
                            Console.Write("You played ");
                            Console.WriteLine(Player2[choiceNum-1].display());
                            if(Player2[choiceNum-1].getColor() == "black"){
                                Console.WriteLine("You played a wild card, what would you like the new color to be?");
                                string colorChoice = Console.ReadLine();
                                Player2[choiceNum-1].setColor(colorChoice);
                            }
                            if(Player2[choiceNum-1].getAbility() == "skip"){
                                player2Ability = "skip";
                            }
                            else if(Player2[choiceNum-1].getAbility() == "wild"){
                                player2Ability = "wild";
                            }
                            else if(Player2[choiceNum-1].getAbility() == "plus2"){
                                player2Ability = "plus2";
                            }
                            else if(Player2[choiceNum-1].getAbility() == "plus4"){
                                player2Ability = "plus4";
                            }
                            moveCard(Player2, choiceNum-1, Discard);
                            played = true;
                            loadTime();
                        }
                        else {
                            Console.WriteLine("That card doesn't work, try again :(");
                        }
                    }
                }
            }
            if(Player2.Count() == 0){
                Console.WriteLine("Player 2 won!");
                continue;
            }
        }
    }

    static List<Card> mainDeck = new List<Card>();
    static List<Card> Discard = new List<Card>();
    static List<Card> Player1 = new List<Card>();
    static List<Card> Player2 = new List<Card>();

    static void shuffleList(List<Card> list){
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

    static void moveCard(List<Card> from, int fromIndex, List<Card> to){
        to.Add(from[fromIndex]);
        from.RemoveAt(fromIndex);
    }

    static void startGame(){
        generateDeck();
        shuffleList(mainDeck);

        int count = 7;
        while(count > 0){
            moveCard(mainDeck, mainDeck.Count()-1, Player1);
            count --;
        }

        count = 7;
        while(count > 0){
            moveCard(mainDeck, mainDeck.Count()-1 , Player2);
            count --;
        }

        moveCard(mainDeck, mainDeck.Count()-1, Discard);

        Console.WriteLine("Main Deck - ");
        foreach(Card i in mainDeck){
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

    static void startTurn(List<Card> hand, int player){
        int count = 1;
        foreach(Card i in hand){
            Console.Write(count+ " - ");
            Console.WriteLine(i.display());
            count++;
        }

        Console.WriteLine("The card is "+Discard[Discard.Count()-1].display());

        if(player == 1){
            Console.WriteLine("Your opponent has "+Player2.Count()+" cards left");
        }
        else if(player == 2){
            Console.WriteLine("Your opponent has "+Player1.Count()+" cards left");
        }
    }

    static void generateDeck(){
        BasicCard red01 = new BasicCard("red", "0");
        mainDeck.Add(red01);
        BasicCard red11 = new BasicCard("red", "1");
        mainDeck.Add(red11);
        BasicCard red21 = new BasicCard("red", "2");
        mainDeck.Add(red21);
        BasicCard red31 = new BasicCard("red", "3");
        mainDeck.Add(red31);
        BasicCard red41 = new BasicCard("red", "4");
        mainDeck.Add(red41);
        BasicCard red51 = new BasicCard("red", "5");
        mainDeck.Add(red51);
        BasicCard red61 = new BasicCard("red", "6");
        mainDeck.Add(red61);
        BasicCard red71 = new BasicCard("red", "7");
        mainDeck.Add(red71);
        BasicCard red81 = new BasicCard("red", "8");
        mainDeck.Add(red81);
        BasicCard red91 = new BasicCard("red", "9");
        mainDeck.Add(red91);

        BasicCard red02 = new BasicCard("red", "0");
        mainDeck.Add(red02);
        BasicCard red12 = new BasicCard("red", "1");
        mainDeck.Add(red12);
        BasicCard red22 = new BasicCard("red", "2");
        mainDeck.Add(red22);
        BasicCard red32 = new BasicCard("red", "3");
        mainDeck.Add(red32);
        BasicCard red42 = new BasicCard("red", "4");
        mainDeck.Add(red42);
        BasicCard red52 = new BasicCard("red", "5");
        mainDeck.Add(red52);
        BasicCard red62 = new BasicCard("red", "6");
        mainDeck.Add(red62);
        BasicCard red72 = new BasicCard("red", "7");
        mainDeck.Add(red72);
        BasicCard red82 = new BasicCard("red", "8");
        mainDeck.Add(red82);
        BasicCard red92 = new BasicCard("red", "9");
        mainDeck.Add(red92);

        BasicCard blue01 = new BasicCard("blue", "0");
        mainDeck.Add(blue01);
        BasicCard blue11 = new BasicCard("blue", "1");
        mainDeck.Add(blue11);
        BasicCard blue21 = new BasicCard("blue", "2");
        mainDeck.Add(blue21);
        BasicCard blue31 = new BasicCard("blue", "3");
        mainDeck.Add(blue31);
        BasicCard blue41 = new BasicCard("blue", "4");
        mainDeck.Add(blue41);
        BasicCard blue51 = new BasicCard("blue", "5");
        mainDeck.Add(blue51);
        BasicCard blue61 = new BasicCard("blue", "6");
        mainDeck.Add(blue61);
        BasicCard blue71 = new BasicCard("blue", "7");
        mainDeck.Add(blue71);
        BasicCard blue81 = new BasicCard("blue", "8");
        mainDeck.Add(blue81);
        BasicCard blue91 = new BasicCard("blue", "9");
        mainDeck.Add(blue91);

        BasicCard blue02 = new BasicCard("blue", "0");
        mainDeck.Add(blue02);
        BasicCard blue12 = new BasicCard("blue", "1");
        mainDeck.Add(blue12);
        BasicCard blue22 = new BasicCard("blue", "2");
        mainDeck.Add(blue22);
        BasicCard blue32 = new BasicCard("blue", "3");
        mainDeck.Add(blue32);
        BasicCard blue42 = new BasicCard("blue", "4");
        mainDeck.Add(blue42);
        BasicCard blue52 = new BasicCard("blue", "5");
        mainDeck.Add(blue52);
        BasicCard blue62 = new BasicCard("blue", "6");
        mainDeck.Add(blue62);
        BasicCard blue72 = new BasicCard("blue", "7");
        mainDeck.Add(blue72);
        BasicCard blue82 = new BasicCard("blue", "8");
        mainDeck.Add(blue82);
        BasicCard blue92 = new BasicCard("blue", "9");
        mainDeck.Add(blue92);

        BasicCard yellow01 = new BasicCard("yellow", "0");
        mainDeck.Add(yellow01);
        BasicCard yellow11 = new BasicCard("yellow", "1");
        mainDeck.Add(yellow11);
        BasicCard yellow21 = new BasicCard("yellow", "2");
        mainDeck.Add(yellow21);
        BasicCard yellow31 = new BasicCard("yellow", "3");
        mainDeck.Add(yellow31);
        BasicCard yellow41 = new BasicCard("yellow", "4");
        mainDeck.Add(yellow41);
        BasicCard yellow51 = new BasicCard("yellow", "5");
        mainDeck.Add(yellow51);
        BasicCard yellow61 = new BasicCard("yellow", "6");
        mainDeck.Add(yellow61);
        BasicCard yellow71 = new BasicCard("yellow", "7");
        mainDeck.Add(yellow71);
        BasicCard yellow81 = new BasicCard("yellow", "8");
        mainDeck.Add(yellow81);
        BasicCard yellow91 = new BasicCard("yellow", "9");
        mainDeck.Add(yellow91);

        BasicCard yellow02 = new BasicCard("yellow", "0");
        mainDeck.Add(yellow02);
        BasicCard yellow12 = new BasicCard("yellow", "1");
        mainDeck.Add(yellow12);
        BasicCard yellow22 = new BasicCard("yellow", "2");
        mainDeck.Add(yellow22);
        BasicCard yellow32 = new BasicCard("yellow", "3");
        mainDeck.Add(yellow32);
        BasicCard yellow42 = new BasicCard("yellow", "4");
        mainDeck.Add(yellow42);
        BasicCard yellow52 = new BasicCard("yellow", "5");
        mainDeck.Add(yellow52);
        BasicCard yellow62 = new BasicCard("yellow", "6");
        mainDeck.Add(yellow62);
        BasicCard yellow72 = new BasicCard("yellow", "7");
        mainDeck.Add(yellow72);
        BasicCard yellow82 = new BasicCard("yellow", "8");
        mainDeck.Add(yellow82);
        BasicCard yellow92 = new BasicCard("yellow", "9");
        mainDeck.Add(yellow92);

        BasicCard green01 = new BasicCard("green", "0");
        mainDeck.Add(green01);
        BasicCard green11 = new BasicCard("green", "1");
        mainDeck.Add(green11);
        BasicCard green21 = new BasicCard("green", "2");
        mainDeck.Add(green21);
        BasicCard green31 = new BasicCard("green", "3");
        mainDeck.Add(green31);
        BasicCard green41 = new BasicCard("green", "4");
        mainDeck.Add(green41);
        BasicCard green51 = new BasicCard("green", "5");
        mainDeck.Add(green51);
        BasicCard green61 = new BasicCard("green", "6");
        mainDeck.Add(green61);
        BasicCard green71 = new BasicCard("green", "7");
        mainDeck.Add(green71);
        BasicCard green81 = new BasicCard("green", "8");
        mainDeck.Add(green81);
        BasicCard green91 = new BasicCard("green", "9");
        mainDeck.Add(green91);

        BasicCard green02 = new BasicCard("green", "0");
        mainDeck.Add(green02);
        BasicCard green12 = new BasicCard("green", "1");
        mainDeck.Add(green12);
        BasicCard green22 = new BasicCard("green", "2");
        mainDeck.Add(green22);
        BasicCard green32 = new BasicCard("green", "3");
        mainDeck.Add(green32);
        BasicCard green42 = new BasicCard("green", "4");
        mainDeck.Add(green42);
        BasicCard green52 = new BasicCard("green", "5");
        mainDeck.Add(green52);
        BasicCard green62 = new BasicCard("green", "6");
        mainDeck.Add(green62);
        BasicCard green72 = new BasicCard("green", "7");
        mainDeck.Add(green72);
        BasicCard green82 = new BasicCard("green", "8");
        mainDeck.Add(green82);
        BasicCard green92 = new BasicCard("green", "9");
        mainDeck.Add(green92);

        Skip redS1 = new Skip("red", "S");
        mainDeck.Add(redS1);
        Skip redS2 = new Skip("red", "S");
        mainDeck.Add(redS2);
        Reverse redR1 = new Reverse("red", "R");
        mainDeck.Add(redR1);
        Reverse redR2 = new Reverse("red", "R");
        mainDeck.Add(redR2);
        Plus2 redp21 = new Plus2("red", "+2");
        mainDeck.Add(redp21);
        Plus2 redp22 = new Plus2("red", "+2");
        mainDeck.Add(redp22);

        Skip blueS1 = new Skip("blue", "S");
        mainDeck.Add(blueS1);
        Skip blueS2 = new Skip("blue", "S");
        mainDeck.Add(blueS2);
        Reverse blueR1 = new Reverse("blue", "R");
        mainDeck.Add(blueR1);
        Reverse blueR2 = new Reverse("blue", "R");
        mainDeck.Add(blueR2);
        Plus2 bluep21 = new Plus2("blue", "+2");
        mainDeck.Add(bluep21);
        Plus2 bluep22 = new Plus2("blue", "+2");
        mainDeck.Add(bluep22);

        Skip yellowS1 = new Skip("yellow", "S");
        mainDeck.Add(yellowS1);
        Skip yellowS2 = new Skip("yellow", "S");
        mainDeck.Add(yellowS2);
        Reverse yellowR1 = new Reverse("yellow", "R");
        mainDeck.Add(yellowR1);
        Reverse yellowR2 = new Reverse("yellow", "R");
        mainDeck.Add(yellowR2);
        Plus2 yellowp21 = new Plus2("yellow", "+2");
        mainDeck.Add(yellowp21);
        Plus2 yellowp22 = new Plus2("yellow", "+2");
        mainDeck.Add(yellowp22);

        Skip greenS1 = new Skip("green", "S");
        mainDeck.Add(greenS1);
        Skip greenS2 = new Skip("green", "S");
        mainDeck.Add(greenS2);
        Reverse greenR1 = new Reverse("green", "R");
        mainDeck.Add(greenR1);
        Reverse greenR2 = new Reverse("green", "R");
        mainDeck.Add(greenR2);
        Plus2 greenp21 = new Plus2("green", "+2");
        mainDeck.Add(greenp21);
        Plus2 greenp22 = new Plus2("green", "+2");
        mainDeck.Add(greenp22);

        Wild wild1 = new Wild("black", "W");
        mainDeck.Add(wild1);
        Wild wild2 = new Wild("black", "W");
        mainDeck.Add(wild2);
        Wild wild3 = new Wild("black", "W");
        mainDeck.Add(wild3);
        Wild wild4 = new Wild("black", "W");
        mainDeck.Add(wild4);

        Plus4 plus41 = new Plus4("black", "+4");
        mainDeck.Add(plus41);
        Plus4 plus42 = new Plus4("black", "+4");
        mainDeck.Add(plus42);
        Plus4 plus43 = new Plus4("black", "+4");
        mainDeck.Add(plus43);
        Plus4 plus44 = new Plus4("black", "+4");
        mainDeck.Add(plus44);
    }

    static void loadTime(){
        Console.Write("|");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write(@"\");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("|");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write(@"\");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("|");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write(@"\");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("|");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write(@"\");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("|");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write(@"\");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("|");
        Console.Write("\b \b");
        Console.WriteLine();
    }
}