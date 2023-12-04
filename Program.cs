using System;
Main();

void Main(){
Console.WriteLine("B E H O L D  T H E  M A G I C  M O O S E!");
Console.WriteLine("Ask your question and receive the wisdom of The Magic Moose");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();
string question = System.Console.ReadLine();
MooseAnswers(question);
}


static void MooseAnswers( string question) {
    if (question.Length > 0)
    {
        Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {GetAnswer()}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
    }
}
static string GetAnswer() {
    int answerNum = RandomNumber();
    string answer = answerNum == 0 ? "As I see it, yes." : answerNum == 1 ? "Ask again later.": answerNum == 2 ? "Better not tell you now." : answerNum == 3 ? "Cannot predict now.": answerNum == 4 ? "Concentrate and ask again.": answerNum == 5 ? "Don't count on it." : answerNum == 6 ? "It is certain.": answerNum == 7 ? "It is decidedly so." : answerNum == 8 ? "Most likely.": answerNum == 9 ? "My reply is no." : answerNum == 10 ? "My sources say no.": answerNum == 11 ? "Outlook not so good." : answerNum == 12 ? "Outlook good.": answerNum == 13 ? "Reply hazy, try again." : answerNum == 14 ? "Signs point to yes.": answerNum == 15 ? "Very doubtful." : answerNum == 16 ? "Without a doubt.": answerNum == 17 ? "Yes." : answerNum == 18 ? "Yes - definitely.": answerNum == 19 ? "You may rely on it" : "ERROR: Number generated was greater than 19";

    return answer;
    
}

static int RandomNumber() {
    Random r = new Random();
    int genRand= r.Next(0,19);
   return genRand;
}

void MagicMoose(string answer)
{ Console.WriteLine($@"
                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {answer}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");}