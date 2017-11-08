//Kayak Hell Adventure Game. Max Senez. Hann- Neeever mind. Nov. 6. 2017
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Choose_your_own_adventure
{
    public partial class adventureForm : Form
    {
        //Variables
        int scene = 0;

        public adventureForm()
        {
            InitializeComponent();
            outputLabel.Text = "You're about to go on a solo 7 day kayaking trip. You chose bring with you..";
            wLabel.Text = "W: Fire starter";
            aLabel.Text = "A: Stainless steel pot";
            sLabel.Text = "S: Water filter";
            dLabel.Text = "D: Fishing Rod and bait";
        }

        private void adventureForm_KeyDown(object sender, KeyEventArgs e)
        {
            //Button Sound
            SoundPlayer button = new SoundPlayer(Properties.Resources.Baseball_beep);
            SoundPlayer win = new SoundPlayer(Properties.Resources.Win);

            //Setting Random
            Random random = new Random();
            int randNum = random.Next(1, 11);
           
            //If statements
           
            //W Key
            if (e.KeyCode == Keys.W)
            {
                button.Play();

                if (scene == 0) { scene = 1; }
                //Fire Starter
                else if (scene == 1) { scene = 7; }
                else if (scene == 7) { scene = 23; }
                else if (scene == 23 && randNum >=7){ scene = 26; }//30%
                else if (scene == 23 && randNum < 7) { scene = 25; } //70%
                else if (scene == 27) { scene = 29; }
                else if (scene == 26) { scene = 28; }
                else if (scene == 6 ) { scene = 17; }
                else if (scene == 17) { scene = 19; }
                else if (scene == 18) { scene = 22; }
                else if (scene == 5) { scene = 15; }
                else if (scene == 8) { scene = 9; }
                else if (scene == 11) { scene = 14; }

                //Fishing Rod
                else if (scene == 2) { scene = 30; }
                else if (scene == 30) { scene = 46; }
                else if (scene == 46 && randNum >= 7) { scene = 49; }//30%
                else if (scene == 46 && randNum < 7) { scene = 50; } //70%
                else if (scene == 48) { scene = 51; }
                else if (scene == 49) { scene = 52; }
                else if (scene == 32) { scene = 42; }
                else if (scene == 42) { scene = 43; }
                else if (scene == 31) { scene = 40; }
                else if (scene == 33) { scene = 34; }
                else if (scene == 35) { scene = 39; }

                //Pot
                else if (scene == 3) { scene = 78; }
                else if (scene == 78) { scene = 96; }
                else if (scene == 96 && randNum >= 7) { scene = 100; }//30%
                else if (scene == 96 && randNum < 7) { scene = 102; } //70%
                else if (scene == 100) { scene = 101; }
                else if (scene == 79) { scene = 90; }
                else if (scene == 90) { scene = 91; }
                else if (scene == 92) { scene = 94; }
                else if (scene == 98) { scene = 99; }
                else if (scene == 80) { scene = 88; }
                else if (scene == 81) { scene = 82; }
                else if (scene == 84) { scene = 85; }

                //Water Filter
                else if (scene == 4) { scene = 53; }
                else if (scene == 53) { scene = 71; }
                else if (scene == 71 && randNum >= 7) { scene = 74; }//30%
                else if (scene == 71 && randNum < 7) { scene = 73; } //70%
                else if (scene == 74) { scene = 76; }
                else if (scene == 75) { scene = 77; }
                else if (scene == 54) { scene = 65; }
                else if (scene == 65) { scene = 70; }
                else if (scene == 66) { scene = 68; }
                else if (scene == 55) { scene = 63; }
                else if (scene == 56) { scene = 57; }
                else if (scene == 59) { scene = 62; }

                //'End Game' Scenes
                else if (scene == 9) { scene = 103; }
                else if (scene == 10) { scene = 104; }
                else if (scene == 12) { scene = 103; }
                else if (scene == 13) { scene = 103; }
                else if (scene == 14) { scene = 103; }
                else if (scene == 15) { scene = 103; }
                else if (scene == 16) { scene = 103; }
                else if (scene == 19) { scene = 104; }
                else if (scene == 20) { scene = 103; }
                else if (scene == 22) { scene = 103; }
                else if (scene == 21) { scene = 103; }
                else if (scene == 25) { scene = 103; }
                else if (scene == 28) { scene = 103; }
                else if (scene == 29) { scene = 103; }
                else if (scene == 34) { scene = 103; }
                else if (scene == 36) { scene = 103; }
                else if (scene == 37) { scene = 103; }
                else if (scene == 38) { scene = 103; }
                else if (scene == 39) { scene = 103; }
                else if (scene == 40) { scene = 103; }
                else if (scene == 41) { scene = 103; }
                else if (scene == 43) { scene = 103; }
                else if (scene == 44) { scene = 103; }
                else if (scene == 45) { scene = 104; }
                else if (scene == 50) { scene = 103; }
                else if (scene == 52) { scene = 103; }
                else if (scene == 51) { scene = 103; }
                else if (scene == 57) { scene = 103; }
                else if (scene == 58) { scene = 103; }
                else if (scene == 60) { scene = 103; }
                else if (scene == 61) { scene = 103; }
                else if (scene == 62) { scene = 103; }
                else if (scene == 63) { scene = 103; }
                else if (scene == 64) { scene = 103; }
                else if (scene == 70) { scene = 104; }
                else if (scene == 69) { scene = 103; }
                else if (scene == 68) { scene = 103; }
                else if (scene == 67) { scene = 103; }
                else if (scene == 73) { scene = 103; }
                else if (scene == 76) { scene = 104; }
                else if (scene == 77) { scene = 104; }
                else if (scene == 82) { scene = 103; }
                else if (scene == 83) { scene = 103; }
                else if (scene == 85) { scene = 103; }
                else if (scene == 86) { scene = 103; }
                else if (scene == 87) { scene = 104; }
                else if (scene == 88) { scene = 103; }
                else if (scene == 89) { scene = 103; }
                else if (scene == 91) { scene = 103; }
                else if (scene == 93) { scene = 103; }
                else if (scene == 94) { scene = 103; }
                else if (scene == 95) { scene = 103; }
                else if (scene == 102) { scene = 103; }
                else if (scene == 101) { scene = 103; }
                else if (scene == 99) { scene = 103; }

                else if (scene == 103) { scene = 0; }
                else if (scene == 104) { this.Close(); }
            }
           
            //A Key
            if (e.KeyCode == Keys.A)
            {
                button.Play();

                if (scene == 0) { scene = 3; }
                //Pot
                else if (scene == 3) { scene = 79; }
                else if (scene == 80) { scene = 81; }
                else if (scene == 81) { scene = 83; }
                else if (scene == 84) { scene = 86; }
                else if (scene == 79) { scene = 89; }
                else if (scene == 90) { scene = 93; }
                else if (scene == 78) { scene = 97; }
                else if (scene == 97) { scene = 98; }
                else if (scene == 92) { scene = 95; }

                //Fire Starter
                else if (scene == 1) { scene = 6; }
                else if (scene == 6) { scene = 16; }
                else if (scene == 7) { scene = 24; }
                else if (scene == 24) { scene = 27; }
                else if (scene == 27) { scene = 29; }
                else if (scene == 17) { scene = 20; }
                else if (scene == 18) { scene = 21; }
                else if (scene == 5) { scene = 8; }
                else if (scene == 8) { scene = 10; }
                else if (scene == 11) { scene = 13; }

                //Fishing Rod
                else if (scene == 2) { scene = 32; }
                else if (scene == 30) { scene = 47; }
                else if (scene == 31) { scene = 33; }
                else if (scene == 33) { scene = 36; }
                else if (scene == 35) { scene = 38; }
                else if (scene == 32) { scene = 41; }
                else if (scene == 42) { scene = 45; }
                else if (scene == 47) { scene = 48; }
                else if (scene == 48) { scene = 51; }

                //Water Filter
                else if (scene == 4) { scene = 54; }
                else if (scene == 55) { scene = 56; }
                else if (scene == 56) { scene = 58; }
                else if (scene == 59) { scene = 61; }
                else if (scene == 54) { scene = 64; }
                else if (scene == 65) { scene = 69; }
                else if (scene == 66) { scene = 67; }
                else if (scene == 53) { scene = 72; }
                else if (scene == 72) { scene = 75; }
                else if (scene == 75) { scene = 77; }

                else if (scene == 103) { this.Close(); }
            }
           
            //S Key
            if (e.KeyCode == Keys.S)
            {
                button.Play();

                if (scene == 0) { scene = 4; }
                //Water Filter
                else if (scene == 4) { scene = 55; }
                else if (scene == 56) { scene = 59; }
                else if (scene == 59) { scene = 60; }
                else if (scene == 65) { scene = 66; }
                
                //Fire Starter
                else if (scene == 1) { scene = 5; }
                else if (scene == 8) { scene = 11; }
                else if (scene == 11) { scene = 12; }
                else if (scene == 17) { scene = 18; }

                //Fishing Rod
                else if (scene == 2) { scene = 31; }
                else if (scene == 33) { scene = 35; }
                else if (scene == 35) { scene = 37; }
                else if (scene == 42) { scene = 44; }

                //Pot
                else if (scene == 3) { scene = 80; }
                else if (scene == 81) { scene = 84; }
                else if (scene == 84) { scene = 87; }
                else if (scene == 90) { scene = 92; }
            }
            
            //D Key
            if (e.KeyCode == Keys.D)
            {
                button.Play();
                if (scene == 0) { scene = 2; }
            }

            //Switch statements
            switch (scene)
            {
                case 0:
                    outputLabel.BackColor = Color.Black;
                    outputLabel.Text = "You're about to go on a solo 7 day kayaking trip. You chose bring with you..";
                    wLabel.Text = "W: Fire starter";
                    aLabel.Text = "A: Stainless steel pot";
                    sLabel.Text = "S: Water filter";
                    dLabel.Text = "D: Fishing Rod and bait";
                    break;
                case 1:
                    outputLabel.Text = "You head out onto the water with all your supplies. You're lost for 10 days and you reach a fork in the river. Do you...";
                    wLabel.Text = "W: Go left";
                    aLabel.Text = "A: Continue following the stream you're on";
                    sLabel.Text = "S: Go right";
                    dLabel.Text = "";
                    break;
                case 2:
                    outputLabel.Text = "You head out onto the water with all your supplies. You're lost for 10 days and you reach a fork in the river. Do you...";
                    wLabel.Text = "W: Go left";
                    aLabel.Text = "A:Continue following the stream you're on";
                    sLabel.Text = "S: Go right";
                    dLabel.Text = "";
                    break;
                case 3:
                    outputLabel.Text = "You head out onto the water with all your supplies. You're lost for 10 days and you reach a fork in the river. Do you...";
                    wLabel.Text = "W: Go left";
                    aLabel.Text = "A:Continue following the stream you're on";
                    sLabel.Text = "S: Go right";
                    dLabel.Text = "";
                    break;
                case 4:
                    outputLabel.Text = "You head out onto the water with all your supplies. You're lost for 10 days and you reach a fork in the river. Do you...";
                    wLabel.Text = "W: Go left";
                    aLabel.Text = "A:Continue following the stream you're on";
                    sLabel.Text = "S: Go right";
                    dLabel.Text = "";
                    break;
                case 5:
                    outputLabel.Text = "You find yourself in some rapids...";
                    wLabel.Text = "W: Continue through the rapids";
                    aLabel.Text = "A: Decide that it's too dangerous and try to turn around";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 6:
                    outputLabel.Text = "you find yourself in a wide open lake. You see an island in the distance. Do you...";
                    wLabel.Text = "W: Continue to the island";
                    aLabel.Text = "A: Stick shore side";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 7:
                    outputLabel.Text = "You find yourself in marsh. Its starting  to become hard to paddle. Do you...";
                    wLabel.Text = "W: Keep trying to paddle through";
                    aLabel.Text = "A: Decide to turn around";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 8:
                    outputLabel.Text = "You can't turn around and your kayak flips over and you lose all your supplies except for your fire starter. You head for the shore. Do you..";
                    wLabel.Text = "W: Find something to eat";
                    aLabel.Text = "A: Find Shelter";
                    sLabel.Text = "S: Go explore the forest";
                    dLabel.Text = "";
                    break;
                case 9:
                    outputLabel.Text = "You find some berries and pop them in your mouth. Your face turns white and your mouth starts to foam. You die of poising.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 10:
                    outputLabel.Text = "You spend hours building a shelter and light a fire. out of your luck a passing helicopter spots you and you're rescued";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 11:
                    outputLabel.Text = "You run into a mamma bear and cubs.. You..";
                    wLabel.Text = "W: Run";
                    aLabel.Text = "A: Climb the tree to get away";
                    sLabel.Text = "S: Light a fire to spook the bears";
                    dLabel.Text = "";
                    break;
                case 12:
                    outputLabel.Text = "You frantically try and sparks some pine needles, the mamma bear charges you and slashes your throat. You bleed out in the mud.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 13:
                    outputLabel.Text = "Bears are great climbers.The mamma bear pulls you down from the tree and you fall do your death.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 14:
                    outputLabel.Text = "The momma bear sees you as a threat, runs you down and slashes your back with her sharp claws. The slash paralyzes you and you bleed out.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 15:
                    outputLabel.Text = "The rapids lead to waterfalls... you go over the falls and crack you head open your body is lost in your watery grave.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 16:
                    outputLabel.Text = "Bullets riddle your body as a hunter mistakes you for a swimming moose! You die immediately.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 17:
                    outputLabel.Text = "You continue to the island and you've been paddling for hours. You need to find something to eat. Do you....";
                    wLabel.Text = "W: Find some berries";
                    aLabel.Text = "A: Sit and wonder why you didn't";
                    sLabel.Text = "S: Try and set up a trap to catch something to eat.";
                    dLabel.Text = "";
                    break;
                case 18:
                    outputLabel.Text = "Your trap works! Well done! You only have a enough food to last you until the morning. What do you do next?";
                    wLabel.Text = "W: You wait to see if anyone will come by to rescue you";
                    aLabel.Text = "A: Go explore the island";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 19:
                    outputLabel.Text = "Luckily, the berries you found were safe and you manage to survive.  A helicopter reaches the island and flies you to safety";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 20:
                    outputLabel.Text = "You were not proactive and didn't utilize your available tools. You died of starvation.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 21:
                    outputLabel.Text = "You get lost on the island and start panicking running around. You step in a hole and your leg snaps. You pass out and bleed out.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 22:
                    outputLabel.Text = "Nobody comes, and you die";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 23:
                    outputLabel.Text = "Your kayak gets stuck in the mud... Do you...";
                    wLabel.Text = "W: Get out and start towing";
                    aLabel.Text = "A: Ditch the kayak ( You can only carry with you your fire starter )";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 24:
                    outputLabel.Text = "The marsh is too thick and your kayak gets stuck. Do you...";
                    wLabel.Text = "W: Get out and start towing";
                    aLabel.Text = "A: Ditch the kayak ( You can only carry with you your fire starter )";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 25:
                    outputLabel.Text = "Your foot gets stuck in the mud.. you try push out struggling, but only get your other foot stuck.. you slowly sink as the marsh swallows you whole. You suffocate to death.";
                    wLabel.Text = "";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 26:
                    outputLabel.Text = "After hours of trudging through the mud with your kayak, you find a big rock. You pull yourself onto the rock, your feet have brutal trench foot.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 27:
                    outputLabel.Text = "After hours of trudging through the mud, you find a big rock. You pull yourself onto the rock, your feet have brutal trench foot.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 28:
                    outputLabel.Text = "3 days later. You can't drink the mud water and die of thirst sitting in your kayak";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 29:
                    outputLabel.Text = "3 days later. You can't drink the mud water and die of thirst baking on a rock.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 30:
                    outputLabel.Text = "You find yourself in marsh. Its starting  to become hard to paddle. Do you...";
                    wLabel.Text = "W: Keep trying to paddle through";
                    aLabel.Text = "A: Decide to turn around";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 31:
                    outputLabel.Text = "You find yourself in some rapids...";
                    wLabel.Text = "W: Continue through the rapids";
                    aLabel.Text = "A: Decide that it's too dangerous and try to turn around";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 32:
                    outputLabel.Text = "You find yourself in a wide open lake. You see an island in the distance. Do you...";
                    wLabel.Text = "W: Continue to island";
                    aLabel.Text = "A: Stick shore side";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 33:
                    outputLabel.Text = "You can't turn around and your kayak flips over and you lose all your supplies except for your fishing rod and bait. You head for the shore. Do you..";
                    wLabel.Text = "W: Find something to eat";
                    aLabel.Text = "A: Find shelter";
                    sLabel.Text = "S: Go and explore the forest";
                    dLabel.Text = "";
                    break;
                case 34:
                    outputLabel.Text = "You find some berries and pop them in your mouth. Your face turns white and your mouth starts to foam. You die of poising.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 35:
                    outputLabel.Text = "You run into a mamma bear and cubs.. You..";
                    wLabel.Text = "W: Run";
                    aLabel.Text = "A: Climb the tree to get away";
                    sLabel.Text = "S: Yell to try scare the bears away";
                    dLabel.Text = "";
                    break;
                case 36:
                    outputLabel.Text = "Attempting to cut down a tree you're squished and killed instantly.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 37:
                    outputLabel.Text = "Your yelling only aggravates the mamma. She stands on her back legs and slashes your neck. You bleed out in the mud.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 38:
                    outputLabel.Text = "Bears are great climbers. The mamma bear pulls you down from the tree and you fall do your death.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 39:
                    outputLabel.Text = "The momma bear sees you as a threat, runs you down and slashes your back with her sharp claws. The slash paralyzes you and you bleed out.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 40:
                    outputLabel.Text = "The rapids lead to waterfalls... you go over the falls and crack you head open your body is lost in your watery grave.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 41:
                    outputLabel.Text = "Bullets riddle your body as a hunter mistakes you for a swimming moose! You die immediately.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 42:
                    outputLabel.Text = "You continue to the island and you've been paddling for hours. You need to find something to eat. Do you....";
                    wLabel.Text = "W: Find some berries";
                    aLabel.Text = "A: Remember your fishing rod and try to catch something to eat";
                    sLabel.Text = "S: You're too tired to do anything. You sit and wait for someone to rescue you";
                    dLabel.Text = "";
                    break;
                case 43:
                    outputLabel.Text = "The berries you found weren't safe to eat, but you ate them anyways. You died";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 44:
                    outputLabel.Text = "A boat comes by and you dont even notice because you're too busy feeling bad for yourself, and you die.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 45:
                    outputLabel.Text = "You fish for hours catching enough fish until rescuers find you";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 46:
                    outputLabel.Text = "Your kayak gets stuck in the mud... Do you...";
                    wLabel.Text = "W: Get out and start towing";
                    aLabel.Text = "A: Ditch the kayak ( You can only carry with you your fishing rod and bait )";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 47:
                    outputLabel.Text = "The marsh is too thick and your kayak gets stuck. Do you...";
                    wLabel.Text = "W: Get out and start towing";
                    aLabel.Text = "A: Ditch the kayak ( You can only carry with you your fishing rod and bait )";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 48:
                    outputLabel.Text = "After hours of trudging through the mud, you find a big rock. You pull yourself onto the rock, your feet have brutal trench foot.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 49:
                    outputLabel.Text = "After hours of trudging through the mud with your kayak, you find a big rock. You pull yourself onto the rock, your feet have brutal trench foot.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 50:
                    outputLabel.Text = "Your foot gets stuck in the mud.. you try push out struggling, but only get your other foot stuck.. you slowly sink as the marsh swallows you whole. You suffocate to death.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 51:
                    outputLabel.Text = "3 days later. You can't drink the mud water and die of thirst baking on a rock.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 52:
                    outputLabel.Text = "3 days later. You can't drink the mud water and die of thirst sitting in your kayak.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 53:
                    outputLabel.Text = "You find yourself in marsh. Its starting  to become hard to paddle. Do you...";
                    wLabel.Text = "W: Keep trying to paddle through";
                    aLabel.Text = "A: Decide to turn around";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 54:
                    outputLabel.Text = "you find yourself in a wide open lake. You see an island in the distance. Do you...";
                    wLabel.Text = "W: Continue to the island";
                    aLabel.Text = "A: Stick shore side";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 55:
                    outputLabel.Text = "You find yourself in some rapids...";
                    wLabel.Text = "W: Continue through the rapids";
                    aLabel.Text = "A: Decide that it's too dangerous and try to turn around";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 56:
                    outputLabel.Text = "You can't turn around and your kayak flips over and you lose all your supplies except for your filter. You head for the shore. Do you..";
                    wLabel.Text = "W: Find something to eat";
                    aLabel.Text = "A: Find shelter";
                    sLabel.Text = "S: Go and explore the forest";
                    dLabel.Text = "";
                    break;
                case 57:
                    outputLabel.Text = "You find some berries and pop them in your mouth. Your face turns white and your mouth starts to foam. You die of poising.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 58:
                    outputLabel.Text = "Attempting to cut down a tree you're squished and killed instantly";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 59:
                    outputLabel.Text = "You run into a mamma bear and cubs.. You..";
                    wLabel.Text = "W: Run";
                    aLabel.Text = "A: Climb the tree to get away";
                    sLabel.Text = "S: Yell to try scare the bears away";
                    dLabel.Text = "";
                    break;
                case 60:
                    outputLabel.Text = "Your yelling only aggravates the mamma. She stands on her back legs and slashes your neck. You bleed out in the mud.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 61:
                    outputLabel.Text = "Bears are great climbers. The mamma bear pulls you down from the tree and you fall do your death.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 62:
                    outputLabel.Text = "The momma bear sees you as a threat, runs you down and slashes your back with her sharp claws. The slash paralyzes you and you bleed out.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 63:
                    outputLabel.Text = "The rapids lead to waterfalls... you go over the falls and crack you head open your body is lost in your watery grave.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 64:
                    outputLabel.Text = "Bullets riddle your body as a hunter mistakes you for a swimming moose! You die immediately.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 65:
                    outputLabel.Text = "You continue to the island and you've been paddling for hours. You need to find something to eat. Do you....";
                    wLabel.Text = "W: Find some berries.";
                    aLabel.Text = "A: Sit and wonder why you didn't chose to bring your fishing rod.";
                    sLabel.Text = "S: Try and set up a trap to catch something to eat.";
                    dLabel.Text = "";
                    break;
                case 66:
                    outputLabel.Text = "Your trap works! Well done! You only have a enough food to last you until the morning. What do you do next?";
                    wLabel.Text = "W: You wait to see if anyone will come by to rescue you";
                    aLabel.Text = "A: Go explore the island";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 67:
                    outputLabel.Text = "You get lost on the island and start panicking running around. You step in a hole and your leg snaps. You pass out and bleed out.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 68:
                    outputLabel.Text = "Nobody comes, and you die";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 69:
                    outputLabel.Text = "You were not proactive and didn't utilize your available tools. You died of starvation.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 70:
                    outputLabel.Text = "Luckily, the berries you found were safe and you manage to survive.  A helicopter reaches the island and flies you to safety.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 71:
                    outputLabel.Text = "Your kayak gets stuck in the mud... Do you...";
                    wLabel.Text = "W: Get out and start towing";
                    aLabel.Text = "A: Ditch the kayak ( You can only carry with you your water filter )";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 72:
                    outputLabel.Text = "The marsh is too thick and your kayak gets stuck. Do you...";
                    wLabel.Text = "W: Get out and start towing";
                    aLabel.Text = "A: Ditch the kayak ( You can only carry with you your water filter )";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 73:
                    outputLabel.Text = "Your foot gets stuck in the mud.. you try push out struggling, but only get your other foot stuck.. you slowly sink as the marsh swallows you whole. You suffocate to death.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 74:
                    outputLabel.Text = "After hours of trudging through the mud with your kayak, you find a big rock. You pull yourself onto the rock, your feet have brutal trench foot.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 75:
                    outputLabel.Text = "After hours of trudging through the mud, you find a big rock. You pull yourself onto the rock, your feet have brutal trench foot.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 76:
                    outputLabel.Text = "3 days later. Sun burnt and starving a passing search and rescue helicopter spots your kayak.You manage to survive by drinking the muddy water through the water filter.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 77:
                    outputLabel.Text = "3 days later. Sun burnt and starving a passing search and rescue helicopter spots your kayak.You manage to survive by drinking the muddy water through the water filter.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 78:
                    outputLabel.Text = "You find yourself in marsh. Its starting  to become hard to paddle. Do you...";
                    wLabel.Text = "W: Keep trying to paddle through";
                    aLabel.Text = "A: Decide to turn around";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 79:
                    outputLabel.Text = "You find yourself in a wide open lake. You see an island in the distance. Do you...";
                    wLabel.Text = "W: Continue to the island";
                    aLabel.Text = "A: Stick shore side";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 80:
                    outputLabel.Text = "You find yourself in some rapids...";
                    wLabel.Text = "W: Continue through the rapids";
                    aLabel.Text = "A: Decide that it's too dangerous and try to turn around";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 81:
                    outputLabel.Text = "You can't turn around and your kayak flips over and you lose all your supplies. You head for the shore. Do you..";
                    wLabel.Text = "W: Find something to eat";
                    aLabel.Text = "A: Find shelter";
                    sLabel.Text = "S: Go and explore the forest";
                    dLabel.Text = "";
                    break;
                case 82:
                    outputLabel.Text = "You find some berries and pop them in your mouth. Your face turns white and your mouth starts to foam. You die of poising.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 83:
                    outputLabel.Text = "Attempting to cut down a tree you're squished and killed instantly";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 84:
                    outputLabel.Text = "You run into a mamma bear and cubs.. You..";
                    wLabel.Text = "W: Run";
                    aLabel.Text = "A: Climb a nearby tree to try and escape";
                    sLabel.Text = "S: Try scare the bear away by banging the pot.";
                    dLabel.Text = "";
                    break;
                case 85:
                    outputLabel.Text = "The momma bear sees you as a threat, runs you down and slashes your back with her sharp claws. The slash paralyzes you and you bleed out.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 86:
                    outputLabel.Text = "Bears are great climbers. The mamma bear pulls you down from the tree and you fall do your death.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 87:
                    outputLabel.Text = "You manage to scare the mamma and cubs away. A near by hunter hears you and you are rescued";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 88:
                    outputLabel.Text = "The rapids lead to waterfalls... you go over the falls and crack you head open your body is lost in your watery grave.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 89:
                    outputLabel.Text = "Bullets riddle your body as a hunter mistakes you for a swimming moose! You die immediately.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 90:
                    outputLabel.Text = "You continue to the island and you've been paddling for hours. You need to find something to eat. Do you...";
                    wLabel.Text = "W: Find some berries";
                    aLabel.Text = "A: Sit and wonder why you didn't chose to bring your fishing rod";
                    sLabel.Text = "S: Try and set up a trap to catch something to eat.";
                    dLabel.Text = "";
                    break;
                case 91:
                    outputLabel.Text = "The berries were poisoned! You fall to your knees as the toxins hit your heart, killing you instantly.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 92:
                    outputLabel.Text = "Your trap works! Well done! You only have a enough food to last you until the morning. What do you do next?";
                    wLabel.Text = "W: You wait to see if anyone will come by to rescue you";
                    aLabel.Text = "A: Go explore the island";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 93:
                    outputLabel.Text = "You were not proactive and didn't utilize your available tools. You died of starvation.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 94:
                    outputLabel.Text = "Nobody comes, and you die";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 95:
                    outputLabel.Text = "You get lost on the island and start panicking running around. You step in a hole and your leg snaps. You pass out and bleed out.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 96:
                    outputLabel.Text = "Your kayak gets stuck in the mud... Do you...";
                    wLabel.Text = "W: Get out and start towing";
                    aLabel.Text = "A: Ditch the kayak ( You can only carry with you your pot )";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 97:
                    outputLabel.Text = "The marsh is too thick and your kayak gets stuck. Do you...";
                    wLabel.Text = "W: Get out and start towing";
                    aLabel.Text = "A: Ditch the kayak ( You can only carry with you your pot )";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 98:
                    outputLabel.Text = "After hours of trudging through the mud, you find a big rock. You pull yourself onto the rock, your feet have brutal trench foot.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 99:
                    outputLabel.Text = "3 days later. You can't drink the mud water and die of thirst baking on a rock.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 100:
                    outputLabel.Text = "After hours of trudging through the mud with your kayak, you find a big rock. You pull yourself onto the rock, your feet have brutal trench foot.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 101:
                    outputLabel.Text = "3 days later. You can't drink the mud water and die of thirst sitting in your kayak";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 102:
                    outputLabel.Text = "Your foot gets stuck in the mud.. you try push out struggling, but only get your other foot stuck.. you slowly sink as the marsh swallows you whole. You suffocate to death.";
                    wLabel.Text = "W: Continue";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 103:
                    outputLabel.BackColor = Color.Red;
                    outputLabel.Text = "You died! Would you like to restart or end game?";
                    wLabel.Text = "W: Restart";
                    aLabel.Text = "A: End Game";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 104:
                    win.Play();
                    outputLabel.BackColor = Color.Green;
                    outputLabel.Text = "Congratulations! You Survived!";
                    wLabel.Text = "W: End Game";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
            }
        }
    }
}
