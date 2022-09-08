
// console.write för att t.ex ställa en fråga som man sedan ger svar till på samma rad
// if satser:

//string n = "MicKe";

//string nNameStyle = n[0].ToString().ToUpper() + n[1..].ToLower();

// n[0] betyder FÖRSTA bokstaven i variablen n, ToString() omvandlar DEN bokstaven till en string
// + n[1..].ToLower() gör ALLA bokstäver från den andra till den sista till lower case i variablen n

//if (n.ToLower() == "micke")
//{
//    Console.WriteLine($"hej {nNameStyle}");
//}
//Console.ReadLine();


// if (name == "Micke")
//{
//  Console.WriteLine("Du skrev in rätt namn!");
//}
// else if (name == "Karl")
//{
//    Console.WriteLine("Wtf, Karl?");
//}
// else
//{
//   Console.WriteLine("Du skrev in fel namn!");
//}
Console.WriteLine("USE FULLSCREEN FOR BEST EXPERIENCE");

Console.Write("\nEnter your name: ");
string name = Console.ReadLine();
string nameNamestyle = name[0].ToString().ToUpper() + name[1..].ToLower();
Console.WriteLine($"Hello {nameNamestyle}.");
Console.Write("Press enter to continue");
Console.ReadLine();
Console.WriteLine("Welcome to:");
Console.WriteLine();
Console.WriteLine(@"░▀█▀░█▀█░▀█▀░█▀▀░█▀▄░█▀█░█▀▀░▀█▀░▀█▀░█░█░█▀▀░░░█▀▀░▀█▀░█▀█░█▀▄░█░█
░░█░░█░█░░█░░█▀▀░█▀▄░█▀█░█░░░░█░░░█░░▀▄▀░█▀▀░░░▀▀█░░█░░█░█░█▀▄░░█░
░▀▀▀░▀░▀░░▀░░▀▀▀░▀░▀░▀░▀░▀▀▀░░▀░░▀▀▀░░▀░░▀▀▀░░░▀▀▀░░▀░░▀▀▀░▀░▀░░▀░");

Console.Write("Press enter to start");
Console.ReadLine();

Console.WriteLine("You find yourself lying on your bed as the sun rises over the horizon, marking the beginning of a new day.");
Console.Write(">");
Console.ReadLine();

Console.WriteLine("After finishing your morning routine you head down to your garage and leave the house.");
Console.Write(">");
Console.ReadLine();

Console.WriteLine("On your way to the city, you see get a glance at something in the forest.");
Console.WriteLine("You slow down to a stop and think about if you should investigate.");
string investigate = "";

while (investigate != "yes" && investigate != "no" && investigate != "y" && investigate != "n")
{
    Console.Write("\nInvestigate? (Yes/No): ");
    investigate = Console.ReadLine().ToLower();
    if (investigate != "yes" && investigate != "no" && investigate != "y" && investigate != "n")
    {
        Console.WriteLine("Write yes or no damn it.");
    }    
}

// investigate = investigate.ToLower();

if (investigate == "yes" || investigate == "y")
{
    Console.WriteLine("You put on your jacket and exit the car, wondering at what you will find.");
}
else if (investigate == "no" || investigate == "n")
{
    Console.WriteLine("You start going towards the city once again.");
    Console.Write(">");
    Console.ReadLine();

    Console.WriteLine("You are about to approach a roundabout when you suddenly get an e-mail from your boss saying that you're free from work today.");
    Console.Write(">");
    Console.ReadLine();

    Console.WriteLine("Knowing this information you return back to the place where you saw something in the forest and begin to investigate.");
    Console.Write(">");
    Console.ReadLine();

}
Console.WriteLine();
Console.WriteLine(@"░▀█▀░█░█░█▀▀░░░█▀▀░█▀█░█▀▄░█▀▀░█▀▀░▀█▀
░░█░░█▀█░█▀▀░░░█▀▀░█░█░█▀▄░█▀▀░▀▀█░░█░
░░▀░░▀░▀░▀▀▀░░░▀░░░▀▀▀░▀░▀░▀▀▀░▀▀▀░░▀░");
Console.Write(">");
Console.ReadLine();

Console.WriteLine("As you venture deeper into the forest, fog starts to appear around you, impairing your vision.");
Console.Write(">");
Console.ReadLine();

Console.WriteLine("Struggling you eventually make it to a mysterious stone structure.");
Console.Write(">");
Console.ReadLine();

Console.WriteLine("Confused, you look around to see if you manage to find something. After a while you manage to locate a lever which reaveals a secret entrance to a ruin.");
Console.Write(">");
Console.ReadLine();

Console.WriteLine("You head inside and before you lie three doors and think about which one to enter.");
Console.Write(">");
Console.ReadLine();

Console.WriteLine("The door on the left has a sea creature on it. The door in the middle has a portal on it. And the door on the right has some stairs on it.");
string doors = "";

while (doors != "left" && doors != "middle" && doors != "right")
{
    Console.WriteLine("\nWhich door will you enter?");
    doors = Console.ReadLine().ToLower();
    if (doors != "left" && doors != "middle" && doors != "right")
    {
        Console.WriteLine("The way behind you is closed. You may only go forward.");
    }
        
}

if (doors == "left")
{
    Console.WriteLine("");
    Console.WriteLine("You approach the left door and reach out with your hand, The sea creature starts to light up and the door opens.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("You walk down a corridor just to find another door. You open it carefully.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("Behind the door lies an ordinary blue lobster which inflicts so much fear upon you that you suffer from a heart attack and die.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine(@"(////////////(((((((((((((/.,**,,,,,,,,.,/(((((((((((((((///////////////////////
(((((((((((((((((((((((((,,,,,,**,,,,,,..,*(((((((((((((((((((((((((/((//(((////
((((((((((((((((((######*,,.*,..,,,*,,,..,,,,/(((((((((((((((((((((((((((((((((/
(((((((((((((((((((((((/,,.,,..**/**//,//***.,/(((((((((((((((((((((((((((((((((
(#(#######(((#########(*,,,,...,*%&((/*,//(%@%,(((###########(##((((((((((((((((
(#####################/*,,,...*(//(////*/((#(/*/##############################(#
#############(*(#####***,.***/(,((/(#(/#(((*(*//##(/*,,*,/############(((((###(#
############,*///(##(.,*,*,///###*,*/(*((((/(%#(((/(//**/*,.,*//################
(#(/**,,,,,,,*/(((,,***/////((#&&&(//(/((/((&((((///**,,,,,,,*/,**,,,**,,,,,,,*(
************,/(/,,*/////////((#####(/(((#(/(###((///((//***//**,,***,***,,,,,,,,
************,*/,..,(/******//((##(%%/(#(%#(%&#%%(((((((((/,,*******..,,****,,,,,
/////*///*///*,,.,,//*,****,/%%&&&@&#/##&&#(#&&&&%((((#((/**/**///(/*,. .////***
//(///////////, .,,*,*///**/%&%%&@@@&/(#@&&((&&&%%%#####/////*/******/*,...,****
/((((((((((##/,,,**//****/(##/(@@@@@@/(%@@@#(#&%%#((#%#**//////**//////**..,.,//
(##((/##%%%/,//***////////*/****(&&&&((%&&&&((#((#%%%%%##*//**///***/****,..*,**
#((#((%&@&%.*****///(((/////*/*////##(/%%&%(#(#&%%%%%##((#(******,,,,*****,..,,*
((/#&&@/*/,.********//(/////////*////#/#%##&@%(%##((((((((/,.,*((/.*(,*****,...,
//%&@@(/(#..********/////(((/////////#/(&&&&%%(##(((((#%%%(,/*/,,**,*(******,...
#%&@@##(##,.********////((//(///**///(/(%&&&&@#(%%#((((###%((/*,*//****#******..
&&&@@#&##/*.,********////*/((((//****/(//#&&@@&##&%####%%%%%%(,**/(/****#/*****,
&&@@@&##(((,,///**///*****///////***,,*//*/&&@&%(%&%%%%#%%%%%%%#/*(#(/***(/*****
&&@@@%(#(##*,*(//*//////*****/**/****,*////##%&&##%%%%%#%%%#%%%%#(**/*****//****
&&@&@%%#%%#%,,/%%#(((((/**********,,*(#//////((&%(#%&%%%%&#%%##%##*,,*******(***
&&&%&&&###&##.*(%%###(///**,,***////*%//*////////(#&&&%%%%##%##%(##%,.,*****,(**
%&&%&&%&%(%(#*,/########((/********/(%((//////***///%%%#%###%####((%#(,,*(/**,(*
%%%###%%%#(###*,*#######(/*********(%%%#(*/////////(#(%%%######(((#%%##(,,,**,,/
#%&@#(#%&#((##(*,/#######(/*,,,**,*/(&%%#//,((((/(///(/(%##%###(###&#(###(,,,,,.
(%@#(#/##%//####,,*#####(((/*,,*******%%#%*%@&%/*///////,#%###((((#%#(#(((((,,,,
(%@&(/((#&(((%(##*,/######((//*,,****/*,#%//@&&%/.(((/***,(#%#(#(#%#((#(##(##/,,
(#&&(#%(%%%##%(###/*/(######((/******,/(#&%*%&%%%%#(/*****,##(((##%#####(((##((/
##&%#&#%%&#%#((#(#%((((#######(/********#%%(*&%#%#%(/##**/*####(%(##(%#(###(%/(/
((%%#%(%%&#(%////#/((#/(#######((/*,*****/,%*(%%%%%%/##%,,#%%#((#(###%(####(#/(/
(((%((##%###((/(/(/##((///#%%###((/*******/*&&%%%%%%/(%%%%%##(#(##(###(##(##(#/(
#(/%,/(%%%#####%%//(###%%#(//####((((//***,/@&%%%###(/%%%%%%%%##((#%##((((###(((");
Console.WriteLine(@"░█▀▄░█░░░█░█░█▀▀░░░█░░░█▀█░█▀▄░█▀▀░▀█▀░█▀▀░█▀▄░░░█▀▀░█▀█░█▀▄░▀█▀░█▀█░█▀▀
░█▀▄░█░░░█░█░█▀▀░░░█░░░█░█░█▀▄░▀▀█░░█░░█▀▀░█▀▄░░░█▀▀░█░█░█░█░░█░░█░█░█░█
░▀▀░░▀▀▀░▀▀▀░▀▀▀░░░▀▀▀░▀▀▀░▀▀░░▀▀▀░░▀░░▀▀▀░▀░▀░░░▀▀▀░▀░▀░▀▀░░▀▀▀░▀░▀░▀▀▀");
Console.ReadLine();
Environment.Exit(0);
}

else if (doors == "middle")
{
    Console.WriteLine("");
    Console.WriteLine("The middle door opens and you find yourself walking down a dark corridor.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("In the pitch black darkness you lose touch with your surroundings and find yourself in your bed again.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("Everything plays out the same way it did before, eventually ending up at the three doors again and going through the middle.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("You wake up in your bed again and you do the exact same things again.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine(@"                                                                                
                                                                                
                                                                                
                                                                                
              @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%             
              @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@             
               &@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@(              
                    @@@                                   @@                    
                    @@@                                   @@                    
                    @@@                                   @@                    
                    %@@                                  .@@                    
                     @@@    (@@@@@@@@@@@@@@@@@@@@@@@     @@@                    
                      @@@.     *@@@@@@@@@@@@@@@@@      #@@@                     
                        @@@@       #@@@@@@@@@*      ,@@@@                       
                           @@@@@*     &@@@*     #@@@@%                          
                               (@@&     @ *@@@@@@*                              
                                    /@@@@@@#                                    
                               @@@@@@(  @     @@@&                              
                          .@@@@&      @@@@&     .@@@@@                          
                        @@@&       @@@@@@@@@@%       @@@@                       
                      @@@      &@@@@@@@@@@@@@@@@@(     *@@@                     
                     @@&    &@@@@@@@@@@@@@@@@@@@@@@@/    @@@                    
                    &@@    @@@@@@@@@@@@@@@@@@@@@@@@@@&    @@                    
                    @@@    @@@@@@@@@@@@@@@@@@@@@@@@@@@    @@                    
                    @@@    @@@@@@@@@@@@@@@@@@@@@@@@@@@    @@                    
                    @@@                                   @@                    
               @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@              
              @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@             
              @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*             
                                                                                
                                                                                
                                                                                ");
    Console.WriteLine(@"░▀█▀░▀█▀░█▄█░█▀▀░░░█░░░█▀█░█▀█░█▀█░░░█▀▀░█▀█░█▀▄░▀█▀░█▀█░█▀▀
░░█░░░█░░█░█░█▀▀░░░█░░░█░█░█░█░█▀▀░░░█▀▀░█░█░█░█░░█░░█░█░█░█
░░▀░░▀▀▀░▀░▀░▀▀▀░░░▀▀▀░▀▀▀░▀▀▀░▀░░░░░▀▀▀░▀░▀░▀▀░░▀▀▀░▀░▀░▀▀▀");
Console.ReadLine();
Environment.Exit(0);
}

Console.WriteLine("");
Console.WriteLine("The symbol starts to glow and the door opens.");
Console.Write(">");
Console.ReadLine();

Console.WriteLine("You head down the stairs and find a large golden door which is already unlocked");
Console.Write(">");
Console.ReadLine();

Console.WriteLine("Inside the golden vault you can see multiple empty display cases on the walls, but in the middle rest four items on their each stand.");
Console.Write(">");
Console.ReadLine();

Console.WriteLine("Upon coming closer you can identify the four objects, all of them being weapons.");
Console.Write(">");
Console.ReadLine();

Console.WriteLine("The first one is a katana with a black sheathe and a dark blue ribbon.");
Console.WriteLine("Gazing at it fills you with motivation and power.");
Console.Write(">");
Console.ReadLine();

Console.WriteLine("The second one is yet another katana but this one is much bigger than the previous one.");
Console.WriteLine("Its aura awakens feelings of violent anger and revenge.");
Console.Write(">");
Console.ReadLine();

Console.WriteLine("The third weapon is a futuristic looking spear which seems to shapeshift a little on occasion.");
Console.WriteLine("You feel happiness and rythym flowing trough you but your body seems to loathe this.");
Console.Write(">");
Console.ReadLine();

Console.WriteLine("The last weapon is a single edged long sword with a crystal just above the handle.");
Console.WriteLine("This weapon reminds you of your childhood and gives you hope for the future.");
Console.Write(">");
Console.ReadLine();
    
string weapon = "";
while (weapon != "first" && weapon != "second" && weapon != "third" && weapon != "fourth")
{
    Console.WriteLine("\nWhich weapon do you choose?");
    weapon = Console.ReadLine().ToLower();
    if (weapon != "first" && weapon != "second" && weapon != "third" && weapon != "fourth")
    {
        Console.WriteLine("There is no such item.");
    }
}

if (weapon == "first")
{
    Console.WriteLine("With the katana in your hand, you are transported to an arena outside.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("Black clouds begin to appear alongside with a violent storm.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("You feel all the more powerful.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("However you suddenly see two cuts in space-time in front of you which form a portal.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("Trough the portal emerges a man in a black coat with silver hair. He also has the same weapon as you.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("???: Have you come here to put an end to my plans?");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine($"{nameNamestyle}: Who are you?");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("???: That doesn't matter. All you need to know is that you are in my way.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine($"{nameNamestyle}: Wait i know now. You seek to take down your brother. But i forgot your name.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("???: Foolishness. How do you remember my goal but not my name? Even more reason to cut you down.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("You both unsheathe your swords and prepare for a duel.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("The mysterious man parries your attacks perfectly. He pushes you back and starts going into a quickdraw stance.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("???: Now you will meet your end.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("You see him sheathe his sword and the next second you feel a thousand cuts cutting into your body.");
    Console.WriteLine("Everything goes to black.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine(@"                                                                                                                                                                                                        
                                                                                                                                                                                                        
                                                                                                                                                                                                        
                                                                                                                                                                                                        
                                                                                                                                                                                                        
                     ,%#   &    ,(   %             (*     ,%%    ,                % &     & /        # % *%          %      %* /#    #%& (&               (#%/              %(%(             ##         
   .             %%         &         &,%         *(  %(     %/                   (    #/            %.  #%(        %         &  %   %      /%.%#    ,          &%/    *%%     %                 %      
         .  ,%#             %          %/   *  */.%        #  %                  %   %          &/          %   #..&         %     .%/#        *&       (%,      .%%(&  %.        %                 %   
        %%      .            #          /%   %/  %,    %%      %                %%%        %#                 &. %.  .%     %     %       %.      .%      . %&   .%(    ,%    .%     %                 #
   .%(                ,      %          .%&     %    & (      /(&*            ,% %    /%                        %&         %,    &             &     .%%     *             /%%*      */ (.              
%                           (,,     #/     %   &  &         ..   (%  .&.  % ,%  /.&                            %   %     ,/    %.%              (%..(   .%                       %% .#*    .%,          
                              % & (         % %%                  #%  .   % %%# %                             %      /( %     &       #*  *%*           #.  &     %                  %&       *%   #    
                           (/ (         *.  #%                     (%  %%.      &   .&,                     #.         %%   %       .%*    .%                % %                         %%       %     
                       &       &         (  % %*               (   (%%   (   (              ##             %          %   %%   &(                %#               &    #                     (%,     %  
                  /*           %     ,*    %   %    .#      , *#  #   % #      &  (                *&*    %          &   %#  %                        .%.            %/   /                      ,%#    
              &                 % /,      %     (       & %%   %       %.      %        /                % %%      (%   &      %                            %%          %  %*                         %%
         **                    #%        %        / *%      %    #.  %  .#     ,             %         (     *%   %%/ %          ,/                              ,%*       %   %,                       
     &                      &    /      %       #% %  .../*,***///((%(##%%%%%%%%%%%%%%%%%%%%%%%%%&%&&&%&&%%%%%##(%(/*%*,,,%&        %                                  %&     %     *                   
,*                       %       %     %   *,%      &  %                   % *%                   %. %  %       %  &             (%/  (                                     ,%(  &  &    /              
                      %               &( .,         %%           %          % (    .&       %.      %        #,%  &                     .%&                                       %&%  (                
                   %              %  %&          (    %         (            &        (* .&.      *             & .%                       %    #%(                                    %%%        .     
                %            &    # %          ,       %      .              &/ ,/              %&          *  %        %.                    *        *%&                                & &&%.       ,
            .&          /     .#   %        %           (    &            .( %  (               %     ##   % %               *#                 %             .%%(                           %(.  *%%   
         .&                %      ,(     &                  (        %           &             #          & %%                     &              *                   (%&.                      %%   (&%
      /%       *       //        .  # ,                   *    #            #     %          .           /%       /&.                   (#           %                       .%%#         .#%%#.  .((   
   #%     (         %               %                    %  *               &      &        &            %              .%/                   %        %                        /%%&.#%%,     %     *&% 
%#   / /,       %.               %   .             ,    /    #                      #      %          .#                      .%#                  #(     ,          .#%%*                ..,%%#%*      
,    *.     ,%  .#            #.     &                (       &            ,              (          %%                              &%                 ,% (%&*                        &  /,&       %%%*
 .#      %    .(.         #,  ,         ,            %         &           &           /            %                                      #%.  ,%%(          %/                   ./  %,               
    &#/                 ,&   /    ,*# %             *           #          *           %&          %                                  (%#.       (%/             # (%         , % .&                    
 .%%%  %              &     #     (/        .%,   %              .                    %  %       /                         ,%%.                        /%#         (   ,,%* * %,                        
        (%/        ,       #           %   .%*   %    ##                  %          /    %     %                (%,                                         ,%% (.   .  %%   %% .,.                  .%
            & %&          %            ,        ,    *%.       /&*        #                ,  ,(      ,%*                                                  # .*/,  .%&* &          *%,             %%   
              (.   *%/   %              *     &                (%.      .%#       #         #%#                                          ./#*.       #           %%       &%/            &%     %,      
           (     %      &%&             (    %                        , .%#      &#%*      ,  ,                      ./%#*                    .#            #.%              (  %%#         &%(%.       
                    /  &      ,%/          ..                         .%.&      * *&(     %,&%.% ./%%(.                                 /*              % .#                   ,      (%%%(        .%#  
      .               &             %&   %%                 ,,          %    ./%&%/     .   %&* &    %&/                          #,               (.  %                             %..    (%%.        
   #                 %   #               &%*     ..      ./#%&(,.        ,   /         % *       (   ,%%*     /&%,          %.                 %   *#                            %( #*            ,%%/  
,                   #                 /%%%%(.  (&                       &   &           (                      (%&.  .&,%%(               /     %                            *&   %                     
*                ./%%%%#*.    %       %              %*                    ,        %                          /%       .#%#.   .#%%, #     ((                            %    &         /             &
&%%&%*            ,                  %     (              ,&                                         .   #%                      ,*%%#   %/%%#                        &(    %                         & 
    #. #         .                 %.                           #*     (,        %                 %/ #                      #       #(     (%%/   ,%%%*          *%     %                           %  
          %&                      %         .                         &&           .         %*        &                .         %                  .&%&*   #%%%     #.                        (   #   
             %   ,#              &          ,                         ,    (, # . .   *&,               .           #         %(                           %*  /%%%*( *%%%*      .,..              /    
                &       #/     %           /                                    #%                                        .%                           ,% /#/    &       %%%%   %%%%              ,  *  
 #/                #,         %%,            #                     .  #   %%          *,                   (           &/        .*(#(,             %         %                   *%%%(. (&%&/   .      
    .%                *#     &       .&         *                 & &%                      &             *#&&(,   /%                           %.         %                                /%%%%%%%%%%.
        %                .%&                /%%              ,%( .      %        .,(%&%#*.       ,#          (  %/                          ,#          %.              .*#%%%%%(,            *      .#%
           &(             %  %                     %#  (%/,(%%%&%/.  #                                 #    #%/                          %          ,%%%%&#*                                 (          
              (&        .&      % ,/#%%%%%(,   * %%*      %/         #                   *               %*  ,                 ./%&%#%.           #%                                        %           
          ./%%%%%%%(,  %           &.      %&.               #  ,%*                                  %&    /#%%(, /               (            /&                                          &            
        .            %%             ,%%/                    .     # ,  (&.      ,     ,(%#/.     .%*                    .     &             .%                                            %             
       *            /%  %%    (%&        #%                      .(%(.        %%              %%                          #  .            %                                              %              
                                                                                                                                                                                                        
                                                                                                                                                                                                        
                                                                                                                                                                                                        ");
Console.WriteLine(@"░▀█▀░█░█░█▀█░█░█░█▀▀░█▀█░█▀█░█▀▄░░░█▀▀░█░█░▀█▀░█▀▀░░░█▀▀░█▀█░█▀▄░▀█▀░█▀█░█▀▀
░░█░░█▀█░█░█░█░█░▀▀█░█▀█░█░█░█░█░░░█░░░█░█░░█░░▀▀█░░░█▀▀░█░█░█░█░░█░░█░█░█░█
░░▀░░▀░▀░▀▀▀░▀▀▀░▀▀▀░▀░▀░▀░▀░▀▀░░░░▀▀▀░▀▀▀░░▀░░▀▀▀░░░▀▀▀░▀░▀░▀▀░░▀▀▀░▀░▀░▀▀▀");    
Console.ReadLine();
Environment.Exit(0);                                                                                                                                                                                                    
}

else if (weapon == "second")
{
    Console.WriteLine("");
    Console.WriteLine("You pick up the weapon and feel it's weight slowing you down");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("Your body is exhausted and in a swift but sloppy motion you drop the katana.");
    Console.Write(">");
    Console.ReadLine();

    Console.WriteLine("You exit the vault and find a box.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("Inside the box you find some pages which contain the answers you are searching for.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("This ruin appears to be a vault containing several items and weaponry from other worlds.");
    Console.WriteLine("But that's all the information you can find.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("Eventually, you find your way out of the ruins and head back to the car and drive home");
    Console.WriteLine("trying to understand why this place exists and who made it.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine(@"&&#(((///*//**********,,,......                                                                             ,%&%,                                                    ... .
%%##(###((((((((///**/***,,,,,,,.. .                                                 .                    %&&&&&&&&#.          /&&&&&&(                   ./*.       ... .
%&#%#####((#((((((///***********,....... .                                        .&&&&&%,              %&&#,,,,#&&&&&%.  ,%&&&&#*/&&&&(                .%(/*/&,         .
&&########((##(((((((/**************,,,,.                                         (%%,/&&&&&#         %&&(,,, ..,,*(&&&&&&&%**,,,,,,&&&&(              *&*&#&%%.         .
&&%%#######(((((((((///////*,,,,.,.,,,,.,..                                       &&%,,,,,#&&&&&#. .%&&(,,.      ..,*(/*,,,.     .,,,&&&&/           (%,&#(#%&.          ,
%&%#%#######(((((((((((//***********,,,,,....                                    ,%&/.,......,#%&&&&&*,.             ..           ...,&&&.         /&/&/(%  &%.          ,
%&#%##((((((((((((((((((////**,,,,,,,,..........                                 (&&,,..   ......,....                             ...           *&*%#*%   .&%           *
%&%%###((((((((((((((////***,,,,,,,,,...........                                 %&%...           .                *#%&&&&&%(..               *(&*.%*&,    *&%           ,
&%####(((##(##((((#((//****************,,,......                                 &&#...                      #%&/             (&/           %/#&#,%&.      (%(           ,
%&%%%###((((((((((((/***********,,,,........                                .(&&&&&*,.                  *%#..........            %#         %%%&&/%        %%.           .
%&%%##########(((((///(//////*,,,,........                            .(%&&&&&&#*,,,.                (&&&%%&&%*,.......            %/           /#        ,%%            .
&&########(((#(((((((///*******,,,.........                       .%&&&&%(,,,,,..                  %%.........#&&(..... .           /%          ((        %&/            .
%&%%%##(((((((((//***********,,,.......                             #%&&(,...                    (*       . ....*%%#.....            .%,        %,       ,%%             .
%&%#######((/////////////*******,......            *%%&&&&%%%&%#*     (%&&(,,...               #,           ......*%&/ ......          /#      .%        &&.             .
&&%%######((((((((((///(/****,.. .            .%&%(*//(#######((/%&%.   /%%&#.....           #,                .....%%%........         .&/    %*      *%%               .
&&%%##(##(#(((((/*****,,,............      .%&#//(####%%%%%%%%%%%%#%%%    *%&&,...         (/                   .....,&&(.......           ,/(*%  ....%&(                .
&&%%###(((((((/********.........         #&%//#######%%%%%%%%%######&%#     ,#            %                     ......%&&&,..... .            &  ....%&.                 .
&&%%###(((((((//******,,,........     .%&(/#########################%&&                 (/                        ..%&,  %&%.... .           &...../&%                   .
%&%%####(((((/*******,,.....        .%&//############%##############%%%                %,                       ..,&%      (&&*. ......     % ....%&#                    .
&&###((/********..........     ,&&&&&//#######%#%###################%%/               %.                         *%(         *%&%....... .%#....%&%                      .
&&####(/****,,............  #&&(/&&//########################%#####&%/           #(*%&&%#..                  . .,&(             #&&%/(&%(....#&#.                        .
&&###(/******,............&&%*/&%//##############################%&&,           ((/&/(#,%(/#&#*,.            ..,&#                 .*#%%%#/                              .
&&#(///*,,..........    %&%*#&%/(##&&%*,,,,,,,*(&&&##########(##&&(             /&%&/.,.#/,/%&%(,.,(&&(.  . ..,&#                                                        .
&&(///*...........     (&#&&(/##&(,,,,,/(*,,,,,,,,,,/&%#%#####&&(                .&,...&(#&&&#*,,,*(&&#/,,*%%&%%&(                                                       .
&&(///,,,.........     (&&/(##&*,,,,,,*@&@*,,,,,,/&&&,,&%#%&&&.                 %(,,,.&,      ,(&&&&&#*,,,*%/,%/*&.                      .                               .
&&(/,..,,,,...      .&&((###&/,,,,,,,**/(###(*,,,,,,,,,*&&&,                  ,&,,,.*&                *%&&&&&&##&.                    ..,#&&%                            .
&&(*...,.....     *&&//#####%,,,,,..&*,,,,..    %%%%&,,,%&*                 *%,,,..%#                                                  ...(&&&                           ,
&&,,......      %&(//####%%&@,,,,,..#%&&&&&%#%&#%%#&.,,,/&/               *&,,,..%%                                       .,...,,,,,,,,..,,(&&&                          ,
&&,,,.     .(&&(/(####%%%%#%&#,,,,,..&*..#,./%#%##&/.,..(&,             (%,,...#&.           .,,...        ..          .,,,(#(/*,,,,,,,,,,,,(&&&.                    .  .,
&&,,,,...%%(#####%%%%%%%####&&(,,,,,,,*&(..../###&,,,..*&(          ,%%*,,,,,#%            .&&&#,...   .,,,,,,,..      ,,(&&&&&&&&&&&&&&&&&%((&&%.            ..    .. ..,
&&,,,,,.&&%%%%%%%%%%%%%%%%%%#%&&*,,,,,,,,,,*,,,,,,,,,,&&.  ...*#&%*,,,,,,,*&#               /&&&/.,.,,,%&@@&%,.,.,..  ,,(&&%*        ,/#%&%%&&&&&           ............,,
&&.,,,,..%&&###%%#%%%##%%%#%%&&&#&&,,,,,,,,,,,,,,,,/##%&%#(/*,,,,,,,,,,#&/                   #&&&,,,/%&&&&&&&&%(,..,,,,,&&&(                                ...........,,*
&&,*,,**..,,,(&@&&&&&&&&%(*,.. (@/**,,,,,,,*,,,,,,,,,,,*,,*,,,,,,(%&%*                        %&&%/&&&&(   ,#&&&#,.,,,,&&&#.                     .     ...  .....,..,..,,*
&%*////*,,,*/,,,.,**..,,,.....&&,*,,*#/****,,**/((#%&&&&&&&%(.                                ,&&&&&&*       .(&&&(,,,%&&%*                      ..............,,,..,,.***
&#/////*,,//**,,/**,,***,...,%&*,*,,,,*&((/%*...&&(                                            &&&%             /&&&#,&&%.                 ..     .............,,,,.*,,**/
&%/(/((**//*/*/***,***,..,**(&#,,*,,,..,,&#((&(.,&&#                                         ./,.                 ,(&&&%.                  .........,,...,,,...*,,,,,*,**/
&%/((##(///((////****,,****,&&**,*,,,,,,,,,&(,./(&%,&,                                                              *%%.                    ........,*,,,,***,.***,,*****/
&%(####(/(((/*///*///*****,*&%***,,,,,,,,,,,,%(,.(&.,/&*                                                                                 ..  ....,*,,,***,,***,,***,***(((
&%########((//**/(((****,,,%&(**,,,*,,,@&######((###%####(((((((/(((#%%%%%%%%%%%%%%#((/**,#&(                                         ............,******///***********((#
&&##%####((////((((//*,***/&&,,,****,,/&(*(%*,,,,,,,,,,,,,**************,,,,,*****(&&&&&&&&%&&(                              ...... ...........,,*,,***/**(((******///*/((
&&%%%###(((((####(/*****//%&/*******,,&&,,*&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%&&&*                              .................,.,*******/((((#/**(((/(((##
&&%%%###(########///*//*.,&&//**,,,*,&&,,*&%%&&%%%&%%%&&&&&&%%%%%&&&%&&&%&&%&&&&%%%&%%%&%%%%&%                                 .....,,*,,...,,**,,***/(//((#((((*/(#######
&&##%%##%%#####(((///,***(&%/******/%&/**&&%&&%%%%%%%%%%%&%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&&&&.                       ..   ...........,,,*****,,*******/((((######(((###%##
&&%%%%%%%%%######(/*/////(&&///**/*(&#//#&&&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&&&%&&(                         ...........,*****,,,**********////(#(#(##########%#%
&&%#%%%%%##%##%#///(((////&%///////&&***&%&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%%%%%&%&%%&&                            ....,,,,,,,,******,,***///////(((#############%%%%
&&%%%###%#%%##((((%&&&&&&&&&&&&&&&&&///&&%&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%#%%%##%%%%%%&&&&%&&.                       ...........,******,,********//(((((((((########%%%#%%%%
&&###%%%%%#####(##&&&&&(/*/*///((&&(/*#&%&&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&&%%&&/                       .....,,****,,,,,******//((((###((######(####%##%%#%%%%%%
&&#%%%%%##########&&&&&&&&&&#(((#&%///&%%&&%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%&%                   ....,,,,,,,,,,********,,****/(((#################%%%##%%%%%%%
&&###########%####&&&&&&&&&&&&&&%(&&/&&&&&&%%%%%%%%%&%&%%%%&%%%%%%%&&&&&&&%&&&&&&&%&%%&&&.                   .....,,,,,,,****/////((#####################%%%###%%%%%%%%%%%");
Console.WriteLine(@"░▀█▀░█▀▄░█░█░▀█▀░█░█░░░█░█░█▀█░█▀▀░█▀█░█░█░█▀▀░█▀▄░█▀▀░█▀▄
░░█░░█▀▄░█░█░░█░░█▀█░░░█░█░█░█░█░░░█░█░▀▄▀░█▀▀░█▀▄░█▀▀░█░█
░░▀░░▀░▀░▀▀▀░░▀░░▀░▀░░░▀▀▀░▀░▀░▀▀▀░▀▀▀░░▀░░▀▀▀░▀░▀░▀▀▀░▀▀░");
Console.ReadLine();
Environment.Exit(0);
}

else if (weapon == "third")
{
    Console.WriteLine("");
    Console.WriteLine("Your struggle to hold the weapon as you slowly start going insane.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("Your brain tells you to drop it this very second but you refuse.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("You start getting dizzy and fall down on your knees and eventually on the ground.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("As your eyes start to shut and are almost closed, you can see someone walking towards you but can't identify them.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("You wake up lying on your bed. It's yet another new day.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("You cannot seem to recall anything that has happened in the vault.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("Eventually, you start getting ready for work and leave in your car.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("But you feel that something has changed within you.");
    Console.WriteLine("You feel... slightly happier.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine(@"                                                                                
                          ,&&&&&&&&&&&&&&&&&&&&&&*                              
                    .&&&&&,                      #&&&&                          
                   &&&                               #&&&                       
                   &&&                                 .&&&                     
                   &&&                                   &&&                    
                   &&&     (&&&&&&&&&&&&&&(               &&&                   
                   &&&.&&&&&&&&#.      .&&&&&             %&&                   
                   &&&&&&%                &&&%            /&&*                  
                   &&&                     &&&            &&&.                  
                                          &&&             &&&                   
                                         &&&            .&&&                    
                                       &&&,            &&&&                     
                                    &&&&             &&&&(                      
                                 (&&&             %&&&&/                        
                               %&&/            %&&&&&                           
                              &&&            &&&&&                              
                             &&%           &&&&                                 
                            &&&          (&&&                                   
                            &&&          &&&                                    
                            &&&          &&&                                    
                            %&&&&&&&&&&&&&&&,                                   
                             &&&&&&&&&&&&&&&(                                   
                                                                                
                                  .%&&&&/                                       
                              &&&&&&&&&&&&&&&.                                  
                            &&&&           (&&&                                 
                           &&&               &&&                                
                           &&&               &&&                                
                           /&&&             /&&&                                
                             &&&&/        &&&&/                                 
                               ,&&&&&&&&&&&%                                    ");
Console.WriteLine(@"░█▄█░█░█░█▀▀░▀█▀░█▀▀░█▀▄░▀█▀░█▀█░█░█░█▀▀░░░█▀▀░█▀█░█▀▄░▀█▀░█▀█░█▀▀
░█░█░░█░░▀▀█░░█░░█▀▀░█▀▄░░█░░█░█░█░█░▀▀█░░░█▀▀░█░█░█░█░░█░░█░█░█░█
░▀░▀░░▀░░▀▀▀░░▀░░▀▀▀░▀░▀░▀▀▀░▀▀▀░▀▀▀░▀▀▀░░░▀▀▀░▀░▀░▀▀░░▀▀▀░▀░▀░▀▀▀");
Console.ReadLine();
Environment.Exit(0);
}

else
{
    Console.WriteLine("");
    Console.WriteLine("The crystal starts to glow and crack with lightning.");
    Console.Write(">");
    Console.ReadLine();

    Console.WriteLine("You are suddenly transported to an arena outside.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("On the other side is a person which looks just like you and is also holding a sword.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("You start exchanging words:");
    Console.WriteLine($"\n{nameNamestyle}: Who are you?");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine($"'{nameNamestyle}': I'm you but also not you.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine($"{nameNamestyle}: I didn't know I had an evil doppelgänger. Interesting.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine($"'{nameNamestyle}': Anyway, I've come to put you out of your misery. And no more questions now.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine($"{nameNamestyle}: As you wish.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("You both ready your swords.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("The crystal on your blade starts to glow and feel thunder flowing trough you.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("In a swift rotation, you unleash a disc of thunder which flies straight towards 'you'.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("Your clone disintigrates into thin air.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("You don't know what just happened but you feel very good about yourself.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("Suddenly you are back in the vault with the sword in your hands.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("There is also a book lying on the ground.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("Wondering what's inside, you read the book and find out the truth about this place.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("This vault is supposed to store all sorts of items and weaponry from other worlds.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("With time it became abandoned and only the four items you previously saw remained.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("You leave the vault and return to the car with the sword.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine("You drive off towards your home with the sun setting behind you.");
    Console.Write(">");
    Console.ReadLine();
    
    Console.WriteLine(@"                                                                                
                                                                                
                                                                                
                                                                                
              ..,,****,  ...       ..,,,****/(#%%%%#((*,  /***,,,,,             
            ..%      ,(*...         ..,,***//(#%%%%#(/,, %&       (,,           
            .          /*..         ..,,***/(#%%%%%#(/,,%%          *           
           ..         *(...         ..,,***/(#%%%%##(/,.%(/         *           
             .       ((  ..         ..,,***/(#%%%%##(/,.  &&       **           
              .          ..          .,,***/(#%%%%#((/,.          ,.            
              /.         ..          .,,***/(#%%%%#((/.,        .,%             
               / .       ...         .,,**//(%%%%##(/,.        ,//              
                 /*..     ..         .,,**/(#%%%%#((,,,     ,,//                
                    (...   ..        .,,**/(#%%%##(,,,   ,, /                   
                      ,(.,/ ..        .,**/(#%%%#/,,, /**/                      
                          ##/#..      .,**(#%%%,,,,%#((                         
                           ,,*, ..    .,*/(#/**** ##**                          
                           /%.     .   ,*//(//     .*%                          
                                      ,/%%(                                     
                                     .  *%%/                                    
                                   ..  .,/#%#*                                  
                                /(//,.  ../#&&%%&                               
                               %%%%,,,**/(((((%(%%                              
                               %%%..   ..,*/((/&&&                              
                               &&&.   ..,*/(((*&&&                              
                             ,/@@&@@@@@@@#@%@@@@@@%                             
                            /&&&&&&&&&&&&&&%&%&&&&&&                            
                            /@@&&/@@%&@%&@@@&@@@@&(@.                           
                            /@@@&@@@%@@&@@@@@@@&@@@#/                           
                                                                                
                                                       .........................
                                                       ...... .. ... .   . .....");
Console.WriteLine(@"░█▀█░█▀█░█▀▄░█▄█░█▀█░█░░░░░█▀▀░█▀█░█▀▄░▀█▀░█▀█░█▀▀
░█░█░█░█░█▀▄░█░█░█▀█░█░░░░░█▀▀░█░█░█░█░░█░░█░█░█░█
░▀░▀░▀▀▀░▀░▀░▀░▀░▀░▀░▀▀▀░░░▀▀▀░▀░▀░▀▀░░▀▀▀░▀░▀░▀▀▀");
Console.ReadLine();
Environment.Exit(0);
}


Console.ReadLine();