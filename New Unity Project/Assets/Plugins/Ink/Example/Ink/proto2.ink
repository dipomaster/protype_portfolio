VAR name= "Beverly"
VAR call=0


Chapter 1
You're Jon D. Tivé. A retired cop that now works as P. I.. 
It's afternoon, but it feels like late at night. Rain outside. 
You're in your ofice, the walls are full of memorabilia and awards. Medals, photos and newspaper cutouts.
You decide to get coffee and sit at your desk.
->at_desk
===at_desk===
You start drifting, as you did many times before...
*[Drift]
->memory
+[Focus on your latest case]
->Focus
+[Drink coffee]
->Drink

===memory===
It's been 5 years since you left law infocement, you still remember the last batch of cadets you trained. You don't remember their names nor their faces... 
Except one.
+[Beverly]
->Beverly
+[Lilly]
->Lilly
+[Jessica]
->Jessica


===Beverly===
Beverly, attractive, tall with red hair.
~name= "Beverly"
->part1
===Lilly===
Lilly, she was radiant during her graduation cerimony. 
~name= "Lilly"
->part1
===Jessica===
Jessica, she was always looking for beauty in life. 
~name= "Jessica"
->part1
=== part1
<> She wasn't the best recruit, but she had fire in her eyes. {name} was determined and resourceful, destined for greatness.
+[Continue]
->phone
===Focus===
You put aside your memories for now and start reading the file.
{!"Jason was kidnapped from a public park where he and his dad were spending the afternoon..."|"... His Dad, a divorcee, already lost a child..."| ->phone} 
{call>1: ->phone}
+[Continue]
->at_desk
===Drink===
You pick up the mug. {!Bitter.|You take a big sip, hoping that it will help...|Cappuccino...with a hint of cinnamon.| You're out of coffee.|->phone}
{call>0: ->phone}
+[Continue]
->at_desk




===phone===
As you're about to go to refill your mug, the phone on your desk starts ringing.
*[Answer]
->phone.answer
+[Let it ring]
->phone.no_answer

->DONE

= answer
You answer the call.
"Hello, Jon?" the machine says.

->at_phone
->DONE
= no_answer
You choose to ignore it, if it's important they'll call again. Coffee now.
~call++
->at_desk

===at_phone===
You reconize the voice on the other side. You hoped they had lost your number.
<> But there you are, talking.
*"Who died?"
<> you say.
->phone_call.died
*"Oh hey, what's good?"
<> you say.
->phone_call.intro


===phone_call===
=intro
{call>0:"You're not easy to reach, Jon".}
"Something happened, I don't know how to tell you or even if I should"
*"How serious is it?" 
<>you bark.
->phone_call.died
=died
"It's {name}. She's dead."
*Chapter 2
->chapter2
VAR cp2=0
===chapter2===
{name} died three weeks ago. They found her in a ally not far from her apartment.
<> The investigation was quickly closed. She was mugged and killed. But something's wrong, you can feel it in your bones.
You're waiting for the crime scene files to download, your Emulation Investigation Room, E.I.R. in short, is doing boot diagnostics and is worming up.
->chapter2.wait
=wait
{cp2>4:
You received the CS files and you're ready to do some investigation.
-else:
{cp2>0:
Files are still loading and the room isn't ready yet.
}
}
*{cp2>4}Enter the E.I.R.
->eir

+[E.I.R.]
{It's incredible what technology is able to do nowadays; the E.I.R. can recreate a confined area at a given point in time, with accurate weather and temperature. You can't stay long in the room and it resets the changes everytime you go in.| Everything will look and feel like as it was at the crime scene when the PD found {name}.}
~cp2++
->chapter2.wait
+[Remember {name}]
{You recall the last time you spoke with {name}. A month ago. |She would check on you every now and then and with time you started caring about her too. |She never had a father and you never had a daughter.}
~cp2++
->chapter2.wait


->DONE


===eir===
End of the prototype, thanks for playing. please answer the questions in the survey.


->END