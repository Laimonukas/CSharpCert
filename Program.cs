/*
Conditions:

You must use either the do-while statement or the while statement as an outer game loop.
The hero and the monster will start with 10 health points.
All attacks will be a value between 1 and 10.
The hero will attack first.
Print the amount of health the monster lost and their remaining health.
If the monster's health is greater than 0, it can attack the hero.
Print the amount of health the hero lost and their remaining health.
Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
Print the winner.
*/

int playerHealth = 10;
int monsterHealth = 10;

var attack = new Random();


while(playerHealth > 0 && monsterHealth > 0){
    var currentAttack = attack.Next(1,11);
    monsterHealth = monsterHealth - currentAttack;
    monsterHealth = monsterHealth <= 0 ? 0:monsterHealth;
    Console.WriteLine($"Hero attacked the monster for: {currentAttack} damage. Monster has {monsterHealth} remaining health.");
    if (monsterHealth <= 0){
        Console.WriteLine($"Hero has defeated the Monster!");
        return;
    }

    currentAttack = attack.Next(1,11);
    playerHealth = playerHealth - currentAttack;
    playerHealth = playerHealth <= 0 ? 0:playerHealth;
    Console.WriteLine($"Monster attacked the Hero for: {currentAttack} damage. Hero has {playerHealth} remaining health.");
    if (playerHealth <= 0){
        Console.WriteLine($"Monster has defeated the Hero!");
        return;
    }
}