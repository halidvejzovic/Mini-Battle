/** 
Diagram 

Klass
Character
Solution Explorer
objekt
Character player
Charachter enemy

Metod
Attack()
Heal()
TakeDamage()
-------------------------------------------------------------------------
Bakgrund & syfte
Du ska bygga ett litet konsolspel där en spelare och en fiende turas om att attackera eller heala tills någon förlorar alla HP. 
Syftet är att öva på:

klasser, objekt och inkapsling

enkel turordningslogik

(VG) arv, polymorfism och ren kodstruktur

 

Krav – G (godkänt)
Funktionella krav

Spelet körs i konsolen och visar båda parters HP löpande.

Spelaren väljer varje tur: attackera eller heala via tangenttryck (t.ex. a/h).

Båda sidor gör alltid samma skada (AttackPower) men har 20% chans att få en "Critical Strike" och gör då skada lika med 125% av AttackPower.
Fienden gör ett slumpmässigt val (attack/heal).

Attack sänker motståndarens HP; heal höjer ditt HP men inte över max.

Spelet avslutas när någon når 0 HP eller lägre, och ett tydligt slutmeddelande skrivs.

När någon av sidorna hamnar under 50% HP så aktiveras "Rage Mode" och då gör spelaren extra skada. 
(50% mer) Se till så att "Rage Mode" inte kan aktiveras om det redan är aktiverat.
Försök balansera spelat så inte samma spelare vinner hela tiden. 
 

Tekniska krav
Minst en klass som representerar en figur (t.ex. Character) med egenskaper som Name, CurrentHp, MaxHp, AttackPower, HealPower.

class xxx {
värde
 constructor{
 värde
 }
}

Metoder för Attack(),  Heal() och TakeDamage().

Kod som kompilerar och kör utan krasch.

public kan använda variablar metoder utanför klass

constructor 

**/

Charachter player = new Charachter("Spelare", 100, 100, 20, 15);
Charachter enemy = new Charachter("Fiende", 100, 100, 20, 15);

Random random = new Random();



