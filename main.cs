using System;

namespace ExquisiteCorpse
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to the Creature Creator 69000!");
      Console.WriteLine("Would you like to see creatures or create your own?");
      Console.WriteLine("Please type: 'see' or 'create'");
      string seeOrBuild = Console.ReadLine();

      if (seeOrBuild == "see") {
        Console.WriteLine("What creature would you like to see?");
        Console.WriteLine("You can type: 'Monster' 'Ghost' or 'Bug");
        string creatureType = Console.ReadLine();

        switch (creatureType.ToLower()) {
          case "monster":
            BuildACreature("monster");
            break;
          case "ghost":
            BuildACreature("ghost");
            break;
          case "bug":
            BuildACreature("bug");
            break;
        }
      } else if ( seeOrBuild == "create") {
        Console.WriteLine("Let's get started!");
        Console.WriteLine("Your choices for the following questions are...");
        Console.WriteLine("'Monster' 'Ghost' 'Bug'");
        Console.WriteLine("What type of head would you like your creature to have?");
        string response1 = Console.ReadLine();
        Console.WriteLine("What type of body would you like your creature to have?");
        string response2 = Console.ReadLine();
        Console.WriteLine("What type of feet would you like your creature to have?");
        string response3 = Console.ReadLine();
        Console.WriteLine("Generating creature...");
        CustomCreature(response1, response2, response3);
      }
    }

    static void BuildACreature(string name)
    {
      switch(name.ToLower()) {
        case "ghost":
          GhostHead();
          GhostBody();
          GhostFeet();
          break;
        case "monster":
          MonsterHead();
          MonsterBody();
          MonsterFeet();
          break;
        case "bug":
          BugHead();
          BugBody();
          BugFeet();
          break;
        default:
          Console.WriteLine("Please select a creature.");
          break;
      }
    }

    static void CustomCreature(string head, string body, string feet)
    {

      switch(head.ToLower())
      {
        case "ghost":
          GhostHead();
          break;        
        case "monster":
          MonsterHead();
          break;
        case "bug":
          BugHead();
          break;
      }
      switch(body.ToLower())
      {
        case "ghost":
          GhostBody();
          break;        
        case "monster":
          MonsterBody();
          break;
        case "bug":
          BugBody();
          break;
      }
      switch(feet.ToLower())
      {
        case "ghost":
          GhostFeet();
          break;        
        case "monster":
          MonsterFeet();
          break;
        case "bug":
          BugFeet();
          break;
      }

    }

    static void GhostHead()
    {
      Console.WriteLine("     ..-..");
      Console.WriteLine("    ( o o )");
      Console.WriteLine("    |  O  |");
    }

    static void GhostBody()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
    }

    static void GhostFeet()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    '~~~~~'");
    }

    static void BugHead()
    {
      Console.WriteLine("     /   \\");
      Console.WriteLine("     \\. ./");
      Console.WriteLine("    (o + o)");
    }

    static void BugBody()
    {
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
    }

    static void BugFeet()
    {
      Console.WriteLine("     v   v");
      Console.WriteLine("     *****");
    }

    static void MonsterHead()
    {
      Console.WriteLine("     _____");
      Console.WriteLine(" .-,;='';_),-.");
      Console.WriteLine("  \\_\\(),()/_/");
      Console.WriteLine("　  (,___,)");
    }

    static void MonsterBody()
    {
      Console.WriteLine("   ,-/`~`\\-,___");
      Console.WriteLine("  / /).:.('--._)");
      Console.WriteLine(" {_[ (_,_)");
    }

    static void MonsterFeet()
    {
      Console.WriteLine("    |  Y  |");
      Console.WriteLine("   /   |   \\");
      Console.WriteLine("   \"\"\"\" \"\"\"\"");
    }
  }
}
