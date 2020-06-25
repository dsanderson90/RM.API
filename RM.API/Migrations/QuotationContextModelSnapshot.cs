﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RM.API.Contexts;

namespace RM.API.Migrations
{
    [DbContext(typeof(QuotationContext))]
    partial class QuotationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RM.API.Entities.Quotation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Character");

                    b.Property<string>("Episode");

                    b.Property<string>("Quote")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Quotes");

                    b.HasData(
                        new { Id = 1, Character = "Rick Sanchez", Episode = "Rick and Morty, Season 4: Rattlestar Ricklactica", Quote = "I wasn't born into the God business, I fucking earned it." },
                        new { Id = 2, Character = "Rick Sanchez", Episode = "Rick and Morty, Season 4: One Crew Over the Crewcoo's Morty", Quote = "I programmed you to believe that." },
                        new { Id = 3, Character = "Morty Smith", Episode = "Rick and Morty, Season 4: One Crew Over the Crewcoo's Morty", Quote = "Whose kidneys are these?" },
                        new { Id = 4, Character = "Rick Sanchez", Episode = "Rick and Morty, Season 4: One Crew Over the Crewcoo's Morty", Quote = "Stealing stuff is about the stuff, not the stealing." },
                        new { Id = 5, Character = "Summer Smith (voice)", Episode = "Rick and Morty, Season 4: The Old Man and the Seat", Quote = "I going to daughter your brains out, bitch." },
                        new { Id = 6, Character = "Jerry Smith (voice)", Episode = "Rick and Morty, Season 4: The Old Man and the Seat", Quote = "You can't stay mad a guy with this amount of talent." },
                        new { Id = 7, Character = "Morty Smith", Episode = "Rick and Morty, Season 4: Edge of Tomorty", Quote = "Must... continue... moving... in... ways... that... lead... to... dying... with... you." },
                        new { Id = 8, Character = "Rick Sanchez", Episode = "Rick and Morty, Season 4: Edge of Tomorty", Quote = "I think you have to think ahead and live in the moment." },
                        new { Id = 9, Character = "Rick Sanchez", Episode = "Rick and Morty, Season 4: Edge of Tomorty", Quote = "There's a lesson here and I'm not going to be the one to figure it out." },
                        new { Id = 10, Character = "Morty Smith", Episode = "Rick and Morty, Season 4: Edge of Tomorty", Quote = "I ain't better than shit, Jack" },
                        new { Id = 11, Character = "Rick Sanchez", Episode = "Rick and Morty, Season 4: Edge of Tomorty", Quote = "Morty, you know outer space is up right?" },
                        new { Id = 12, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 3: Vindicators 3", Quote = "" },
                        new { Id = 13, Character = "Morty Smith", Episode = "Rick and Morty, Season 2: The Ricks Must Be Crazy", Quote = "You guys, are the fucking worst! Your gods are a lie! Fuck you, fuck nature and fuck trees!" },
                        new { Id = 14, Character = "Summer Smith (voice)", Episode = "Rick and Morty, Season 2: Total Rickall", Quote = "Ooh yeah, shame me. At least when I'm disgusting it's on purpose." },
                        new { Id = 15, Character = "Rick Sanchez / Morty Smith (voice)", Episode = "Rick and Morty, Season 2: Mortynight Run", Quote = "Morty: You sold a gun to a murderer so you could play video games?Rick: Yeah, sure, I mean, if you spend all day shuffling words around, you can make anything sound bad, Morty." },
                        new { Id = 16, Character = "Summer Smith (voice)", Episode = "Rick and Morty, Season 2: Auto Erotic Assimilation", Quote = "[addressing Rick] You and Unity are like... like leggings and mid-calf boots. You think you're great together, but you're just bringing out the worst in each other." },
                        new { Id = 17, Character = "Rick Sanchez / Morty Smith (voice)", Episode = "Rick and Morty, Season 2: Auto Erotic Assimilation", Quote = "Don't waste your brain on those weirdos, Unity. They're no different from any of the aimless chumps that you occupy. They just put you at the center of their lives because you're powerful. And then, because they put you there, they want you to be less powerful. Never gonna happen though, right?" },
                        new { Id = 18, Character = "Unity", Episode = "Rick and Morty, Season 2: Auto Erotic Assimilation", Quote = "Morty: Uhm, should we maybe stop somewhere and get you a coffee? Maybe splash a little water on your face, or...?Unity: No, no. If I wanted to be sober, I wouldn't have gotten drunk." },
                        new { Id = 19, Character = "Morty Smith (voice)", Episode = "Rick and Morty, Season 2: Get Schwifty", Quote = "Mr. President, if I've learned one thing today, it's that sometimes you have to not give a fuck!" },
                        new { Id = 20, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 2: The Ricks Must Be Crazy", Quote = "Wait for the ramp, Morty. They love the slow ramp. It really gets their dicks hard" },
                        new { Id = 21, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 2: The Ricks Must Be Crazy", Quote = "Morty, you gotta flip 'em off. I told them it means 'peace among worlds.' How hilarious is that!" },
                        new { Id = 22, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 2: Total Rickall", Quote = "Jerry: Rick, I don't like glowing rocks in the kitchen trash!Rick: Well, I don't like your unemployed genes in my grandchildren, Jerry, but life is made of little concessions." },
                        new { Id = 23, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 1: Meeseeks and Destroy", Quote = "I can't wait to watch your adventure lay a huge fart." },
                        new { Id = 24, Character = "Morty Smith (voice)", Episode = "Rick and Morty, Season 2: The Ricks Must Be Crazy", Quote = "I masturbated to an extra curvy piece of driftwood the other day!" },
                        new { Id = 25, Character = "Mr. Meeseeks", Episode = "Rick and Morty, Season 1: Meeseeks and Destroy", Quote = "I'm Mr. Meeseeks! Look at me!" },
                        new { Id = 26, Character = "Morty Jr.", Episode = "Rick and Morty, Season 1: Raising Gazorpazorp", Quote = "My life has been a lie! God is dead! The government's lame! Thanksgiving is about killing Indians! Jesus wasn't born on Christmas! They moved the date, it was a pagan holiday!" },
                        new { Id = 27, Character = "Jerry Smith (voice)", Episode = "Rick and Morty, Season 2: Interdimensional Cable 2", Quote = "Shrimply Pibbles: I've dwelt among the humans. Their entire culture is built around their penises. It's funny to say they are small. It's funny to say they are big. I've been at parties where humans held bottles, pencils, thermoses in front of themselves and called out, 'Hey, look at me. I'm Mr. So-and-So Dick. I've got such-as-such for a penis.' I never saw it fail to get a laugh.Jerry: All right! That's enough! You guys are talking about my species! We understand genocide! We do it sometimes!" },
                        new { Id = 28, Character = "Morty Smith (voice)", Episode = "Rick and Morty, Season 3: The Rickchurian Mortydate", Quote = "President: Here's the adventure: some kind of alien goo-ga has infested the Kennedy Sex Tunnels. I want it hunted down and taken out.Morty: Kennedy Sex Tunnels?President: Naturally you'll forget you saw them, along with, in order of national embarrassment: the Truman Cocaine Lounge, the McKinley Hooker Dump, and the Lincoln Slave Colosseum. He didn't free them all. And let me know when you're done" },
                        new { Id = 29, Character = "Summer Smith (voice)", Episode = "Rick and Morty, Season 2: Look Who's Purging Now", Quote = "Jerry: What' you doing? Watching some tv, playing on your phone?Summer: Is that a real question?Jerry: Just making conversation.Summer: Are you? What part of that gives me anything to work with? My choice is to: say nothing, be sarcastic, or bark \"yes\" like a trained animal. It's not a conversation; you're holding me verbally hostage." },
                        new { Id = 30, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 3: The Rickshank Redemption", Quote = "An-and I-I-I'll go out and I'll find some more of that Mulan Szechuan teriyaki dipping sauce, Morty! Th-b-because that's what this is all about, Morty! Th-that's my one-armed man! I'm not driven by avenging my dead family, Morty, that was fake! I-I-I'm driven by finding that McNugget sauce! I want that Mulan McNugget sauce, Morty! That's my series arc, Morty! If it takes nine seasons, I want my McNugget... dipping sauce Szechuan sauce, Morty! That's what's gon-it's gonna take us all the way to the end, Morty!" },
                        new { Id = 31, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 3: Pickle Rick", Quote = "Because I don't respect therapy. Because I'm a scientist. Because I invent, transform, create, and destroy for a living, and when I don't like something about the world, I change it. And I don't think going to a rented office in a strip mall to listen to some agent of averageness explain which words mean which feelings has ever helped anyone do anything. I think it's helped a lot of people get comfortable and stop panicking, which is a state of mind we value in the animals we eat, but not something I want for myself. I'm not a cow. I'm a pickle. When I feel like it. So... you asked." },
                        new { Id = 32, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 2: The Ricks Must Be Crazy", Quote = "Morty: You have a whole planet... sitting around making your power for you?! That's slavery!Rick: It's society! They work for each other, Morty. They pay each other, they buy houses, they get married and make children that replace them when they get too old to make power.Morty: That just sounds like slavery with extra steps!Rick: Ooh-la-la, someone's gonna get laid in college." },
                        new { Id = 33, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 2: Total Rickall", Quote = "Rick: No, \"Steve\" put that memory in your brain so he could live in your house, eat your food and multiply. We could be infested with these things. So, we got to keep an eye out for any zany, wacky characters that pop up.Mr. Poopybutthole: Oooohwee! Whatever you want, Rick, we're here to help!Rick: Thanks, Mr. Poopybutthole. I always could count on you." },
                        new { Id = 34, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 3: The Whirly Dirly Conspiracy", Quote = "'I took your family'? Who do you think had taken more from them when you shot 20 CCs of liquid dreamkiller into my daughter? She was Rick's daughter, Jerry! She had options! That all ended because she felt sorry for you. You act like prey, but you're a predator! You use pity to lure in your victims! That's how you survive! I survive cause I know everything, that snake survives because children wander off, and you survive 'cause people think 'Ooh, this poor piece of shit, he never gets a break! I can't stand the deafening silent wails of his wilting soul! I guess I'll hire him or marry him!'" },
                        new { Id = 35, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 1: Pilot", Quote = "We're the only fehh-friends we got, Morty! It's just Rick and Morty! Ruh-ick and Morty and their adventures, Morty! Rick and Morty forever and forever, 100 years, Rick and Morty's things! Me and Rick and Morty running around and... Rick and Morty time! All day long, forever... all- a hundred days! Rick and Morty forever a hundred times!" },
                        new { Id = 36, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 2: Total Rickall", Quote = "Mr. Beauregard: Ah, Master Rick, remember when you weren't going to shoot me?Rick: [shoots Mr. Beauregard in the face] I guess Iiii did the butler! Hahaaa! Does that, does that scan?Ghost in a Jar: Oh, I-I get it. It's a play on 'the butler did it.'Rick: Thanks Ghost in a Jar. You always were good at pointing out potentially obscure comedy." },
                        new { Id = 37, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 2: A Rickle in Time", Quote = "Morty, sit here. Summer, you sit here. Now, listen—I know the two of you are very different from each other in a lot of ways, but you have to understand that as far as Grandpa's concerned, you're both pieces of shit! Yeah. I can prove it mathematically. Actually, l-l-let me grab my whiteboard. This has been a long time coming, anyways." },
                        new { Id = 38, Character = "Morty Smith (voice)", Episode = "Rick and Morty, Season 2: Big Trouble in Little Sanchez", Quote = "Well then get your shit together, get it all together and put it in a back pack, all your shit, so it's together. And if you gotta take it some where, take it somewhere, you know, take it to the shit store and sell it, or put it in the shit museum. I don't care what you do, you just gotta get it together.Get your shit together." },
                        new { Id = 39, Character = "Poncho", Episode = "Rick and Morty, Season 1: Anatomy Park", Quote = "That's right, baby. A lot of people would pay top dollar to decimate the population. I'll take the highest bidder—Al-Qaeda, North Korea, Republicans, shriners, balding men that work out, people on the Internet that are only turned on by cartoons of Japanese teenagers. Anything is better than working for you, you pompous, negligent, iTunes-gift-card-as-a-holiday bonus-giving mother—" },
                        new { Id = 40, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 2: Total Rickall", Quote = "Rubber baby bubby bunkers!" },
                        new { Id = 41, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 2: Mortynight Run", Quote = "Right, yeah, like nothing shady ever happened in a fully furnished office? You ever hear about Wall Street, Morty? Y-Y-Y'know what those guys do i-in-in their fancy boardrooms? They take their balls and they dip 'em in cocaine and wipe 'em all over each other—y'know, Grandpa goes around and he does his business in public, because Grandpa isn't shady." },
                        new { Id = 42, Character = "Pichael Thompson", Episode = "Rick and Morty, Season 2: Interdimensional Cable 2", Quote = "Pichael Thompson: And then they found out I was attached along for the ride and they said, 'Ah, shit. Well, just fuck it, call him Pichael.'Michael Thompson: [throws papers at Pichael's face] Fuck you, Pichael! You're a fucking piece of shit!" },
                        new { Id = 43, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 2: Total Rickall", Quote = "Wubba-lubba-dub-dub!" },
                        new { Id = 44, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 2: Total Rickall", Quote = "And that's why I always say, 'shum-shum-schlippety-dop!'" },
                        new { Id = 45, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 2: Big Trouble in Little Sanchez", Quote = "Huntin' a vampire with my grandkids!! FUCK!! TINY RI-I-ICK!!!" },
                        new { Id = 46, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 1: Ricksy Business", Quote = "It's not the same, Summer! Lincler's a crazed maniac. He's just a misguided effort of mine to create a morally neutral super-leader by combining the DNA of Adolf Hitler and Abraham Lincoln. Turns out that ehh-it just adds up to a lame, weird... loser." },
                        new { Id = 47, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 2: Get Schwifty", Quote = "Get Schwifty." },
                        new { Id = 48, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 2: A Rickle in Time", Quote = "So, in conclusion, you're both equally mercurial, overly sensitive, clingy, hysterical bird-brain homunculi. And I honestly can't even tell the two of you apart half the time because I don't go by height or age, I go by amount of pain in my ass—which makes you both identical." },
                        new { Id = 49, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 1: Lawnmower Dog", Quote = "Morty: You're talking about Inception?Rick: That's right, Morty! This is gonna be a lot like that, except y'know, it's gonna me-beh... make sense.Morty: Inception made sense!Rick: You don't have to try and impress me, Morty!" },
                        new { Id = 50, Character = "Morty Smith (voice)", Episode = "Rick and Morty, Season 1: Ricksy Business", Quote = "Bird Person: Morty, do you know what wubba lubba dub dub means?Morty: Oh, that's just Rick's stupid nonsense catchphrase.Bird Person: It's not nonsense at all. In my people's tongue, it means, I am in great pain. Please help me." },
                        new { Id = 51, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 3: Rest and Ricklaxation", Quote = "Yeah motherfucker yeah get it get some, right up your fucking bitch ass you fuck! Guess who just discovered a new element! Think you could do that Morty? You think anyonne but me could do it ever in a billion years? Do you think if God existed he could do it? The answer is no. If God exists its fucking me!" },
                        new { Id = 52, Character = "Jerry Smith (voice)", Episode = "Rick and Morty, Season 2: Interdimensional Cable 2", Quote = "Yes, I will! That's right, assholes! Take my penis. Take it all!! And tell Shrimply Pibbles that when the galaxy came calling, Jerry Smith from Earth didn't flinch!" },
                        new { Id = 53, Character = "Morty Smith (voice)", Episode = "Rick and Morty, Season 2: Get Schwifty", Quote = "Morty: Can you fly a Black Hawk?Mr. President: Can the pope's **** fit through a donut?Morty: Eh... I'm not sure?Mr. President: Exactly!" },
                        new { Id = 54, Character = "Jerry Smith (voice)", Episode = "Rick and Morty, Season 1: Rixty Minutes", Quote = "All this time, you've been thinking, 'What if that loser Jerry hadn't talked me out of the abortion?' Well, now you know, you'd be a doctor. Whoop-dee-doo. You'd also be drinking wine, alone in a house full of exotic birds. And I'd be on DiCaprio's yacht, banging Kristen Stewart!" },
                        new { Id = 55, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 2: The Wedding Squanchers", Quote = "See? Our cup runneth over. Now, who wants to go shopping for a brand-new motherfuckin' world?! All right!" },
                        new { Id = 56, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 2: Mortynight Run", Quote = "SHUT THE FUCK UP ABOUT MOONMEN! This isn't a musical number! This is a fucking... operation, we gotta be cool and fucking lay low." },
                        new { Id = 57, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 2: The Ricks Must Be Crazy", Quote = "They named a holiday after me. Ricksgiving. They teach kids about me in school!" },
                        new { Id = 58, Character = "Morty Smith (voice)", Episode = "Rick and Morty, Season 2: Look Who's Purging Now", Quote = "SCREW YOU, RICK! I'LL PURGE YOU TOO, YOU OLD... \"RICKETY\" PIECE OF CRAP! THIS HAS BEEN A LONG TIME COMING! I'M GONNA RIP YOUR FUCKING GUTS OUT AND SMEAR 'EM ALL OVER YOUR FACE! I AIN'T TAKING NO SH-AAAHH!!" },
                        new { Id = 59, Character = "Summer Smith (voice)", Episode = "Rick and Morty, Season 3: The Rickshank Redemption", Quote = "We're miserable Morty! There's a mandatory curfew, their weird calendar made me 47, and they've weaponized the Eiffel tower!" },
                        new { Id = 60, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 3: The ABC's of Beth", Quote = "I don't know, maybe you matter so little that I like you. Or maybe it makes you matter. Maybe I love you. Maybe something about your mother. Don't jump a gift shark in the mouth." },
                        new { Id = 61, Character = "Jerry Smith (voice)", Episode = "Rick and Morty, Season 1: Rick Potion #9", Quote = "Meh, try not to worry about it, Morty. You're a good kid. And there's not a premium on that right now, but you'll be getting girls sometime after Brad's out of shape." },
                        new { Id = 62, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 2: A Rickle in Time", Quote = "Beth: Sweetie, is your shirt on backwards?Jerry: ...Yeah! I like it this way. I'm not stupid!Rick: Man that guy is the Redgrin Grumbholt of pretending he knows what's going on." },
                        new { Id = 63, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 1: Anatomy Park", Quote = "Bloom: Anatomy Park's greatest attraction, young man, isn't the music or the food or the... Pirates of the Pancreas.Rick: 'Watch it!'" },
                        new { Id = 64, Character = "Morty Smith (voice)", Episode = "Rick and Morty, Season 3: Morty's Mind Blowers", Quote = "How many of these are just horrible mistakes I made? I mean, maybe I'd stop making so many if I let myself learn from them." },
                        new { Id = 65, Character = "Evil Morty Smith (voice)", Episode = "Rick and Morty, Season 3: The Ricklantis Mixup", Quote = "This seems like a good time for a drink, and a cold, calculated speech with sinister overtones. A speech about politics, about order, brotherhood, power... but speeches are for campaigning. Now is the time for action." },
                        new { Id = 66, Character = "Beth Smith (voice)", Episode = "Rick and Morty, Season 2: Total Rickall", Quote = "Beth: Sorry Jerry, you're real.Jerry: [crying] I'm a parasite!Beth: Yeah... but you're real." },
                        new { Id = 67, Character = "Summer Smith (voice)", Episode = "Rick and Morty, Season 1: Rixty Minutes", Quote = "You're the little brother. You're not the cause of your parents' misery, you're just a symptom of it." },
                        new { Id = 68, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 1: Pilot", Quote = "And then we're gonna go on even more adventures after that, Morty. And you're gonna keep your mouth shut about it, Morty! Because the world is full of idiots that don't understand what's important, and they'll tear us apart, Morty! But if you stick with me, I'm gonna accomplish great things, Morty, and you're gonna be part of 'em. And together we're gonna run around, Morty, we're gonna- do all of kinds of wonderful things, Morty. Just you and me, Morty." },
                        new { Id = 69, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 1: Something Ricked This Way Comes", Quote = "Rick: Have you acquired creepy specific old stuff from a mysterious antique or thrift store that gives you powers, but fucks with you in unforeseeable ways? Bring it to 'Curse Purge Plus'! I-I use science to un-curse the items for cash, and you get to keep the powers. This guy got mysterious sneakers to make him run faster, but guess what? He would've had to run until he died, making them worthless. I removed the curse, making them worth, like, I don't know, $8 million? See you at the Olympics. This eerily intelligent doll was threatening to murder its family. Now it does their taxes.Doll: Everything's deductible.Rick: Don't pay for cool stuff with your soul. Pay for it with money. You know, like how every store in the world works?" },
                        new { Id = 70, Character = "Morty Smith (voice)", Episode = "Rick and Morty, Season 1: Something Ricked This Way Comes", Quote = "Morty: And also, knock next time, you know? I mean, I'm sitting in here, I'm fourteen! I got a computer in here, you know?Jerry: Oh, I, uh... I think I understa—Morty: You know, you're really playing with fire when you burst in here like that, man.Jerry: I get it. Say no more.Morty: I mean one of these days, you know, you're gonna—you're gonna—you're gonna end up seeing something." },
                        new { Id = 71, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 2: Auto Erotic Assimilation", Quote = "[they both exchange kisses, upping their sexual arousal]Unity: Yes, Rick, yes! Yes, yes!Rick: Wait, wait, stop! H-Hold it! Not like this. We need a hang glider, and a crotchless Uncle Sam costume, and I want the entire field of your largest stadium covered end to end with naked redheads, and I want the stands packed with every man that remotely resembles my father." },
                        new { Id = 72, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 2: Total Rickall", Quote = "Lick, lick, lick my balls! Ha ha ha, yeah!" },
                        new { Id = 73, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 1: Anatomy Park", Quote = "Listen, if the situation keeps on darkening, then you gotta do yourself a favor and pop by Pirates Of The Pancreas. I mean, the top priority is to, you know, get you guys out of there, but, I mean, if that becomes impossible then you gotta treat yourself." },
                        new { Id = 74, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 3: The ABC's of Beth", Quote = "Put a saddle on your universe. Let it kick itself out." },
                        new { Id = 75, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 3: The Ricklantis Mixup", Quote = "You got some of that mermaid puss." },
                        new { Id = 76, Character = "Jerry Smith (voice)", Episode = "Rick and Morty, Season 1: Anatomy Park", Quote = "Jerry: It sounds like you're about to say Jacob is your lover.Leonard Smith: No, no, no. Jacob is your mother's lover. I watch them. Sometimes from a chair, sometimes from a closet. Almost always dressed as Superman." },
                        new { Id = 77, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 2: Big Trouble in Little Sanchez", Quote = "The universe is a little too big to care about something so small." },
                        new { Id = 78, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 2: A Rickle in Time", Quote = "Morty: If you could get out that whole time why didn't you?Rick: Because I waited until I was certain it was what I wanted to do, Morty! That's the difference between you and me: I'm certain, and you're a walking burlap sack filled with turds." },
                        new { Id = 79, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 3: Pickle Rick", Quote = "I'M A PICKLE! I'm pickle Riiiiiick!" },
                        new { Id = 80, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 3: The Rickshank Redemption", Quote = "Yeah, well, tough titties." },
                        new { Id = 81, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 3: The ABC's of Beth", Quote = "Beth: Am I evil?Rick: Worse, you're smart. When you know nothing matters, the universe is yours. And I've never met a universe that was into it. The universe is basically an animal, it grazes on the ordinary. It creates infinite idiots, just to eat them, not unlike your friend Timmy." },
                        new { Id = 82, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 1: Close Rick-Counters of the Rick Kind", Quote = "Don't break an arm jerking yourself off, Morty." },
                        new { Id = 83, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 2: Mortynight Run", Quote = "Stupid-ass, fart-saving, carpet-store motherfucker." },
                        new { Id = 84, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 1: Ricksy Business", Quote = "TO GET R*ugghhb*IGGITY RIGGITY WRECKED SOONN" },
                        new { Id = 85, Character = "Jerry Smith (voice)", Episode = "Rick and Morty, Season 2: Interdimensional Cable 2", Quote = "Ambassador: Mr. Smith, Shrimply Pibbles' life can be saved... if we replace his heart with your human penis.Jerry: I see... Wait, what?!" },
                        new { Id = 86, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 3: The Rickchurian Mortydate", Quote = "I'm Doctor Who in this motherfucker! I could be a clone! I could be a hologram! We could clones controlled by robots controlled by special headsets that the real Rick and Morty are wearing while they're fucking your mother!" },
                        new { Id = 87, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 3: Rickmancing the Stone", Quote = "To live is to risk it all, otherwise you're just an inert chunk of randomly assembled molecules drifting wherever the universe blows you." },
                        new { Id = 88, Character = "Jerry Smith (voice)", Episode = "Rick and Morty, Season 1: Rixty Minutes", Quote = "Beth: When two people create a life together, they set aside their previous lives as individuals.Jerry: Gimme a break! We're not heroes for having unprotected sex on prom night." },
                        new { Id = 89, Character = "Summer Smith (voice)", Episode = "Rick and Morty, Season 2: Total Rickall", Quote = "All I have are pictures are of me and my friends from school. What? What teenage girl has pictures of her family? It's not like we're Mormon or dying" },
                        new { Id = 90, Character = "Morty Smith (voice)", Episode = "Rick and Morty, Season 1: Raising Gazorpazorp", Quote = "Morty: So what?! Y-Y-You could do things inside! Y-You could play guitar, you could masturbate!Morty Jr.: I don't wanna masturbate! I wanna conquer the planet!" },
                        new { Id = 91, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 2: Total Rickall", Quote = "Get off the high road, Summer! We all got pinkeye because you won't stop texting on the toilet." },
                        new { Id = 92, Character = "Morty Smith (voice)", Episode = "Rick and Morty, Season 1: M. Night Shaym-Aliens!", Quote = "No, no, I haven't seen that. I mean, why would a Pop-Tart want to live inside a toaster, Rick? I mean, th-that would be like the scariest place for them to live. Y'know what I mean?" },
                        new { Id = 93, Character = "Jerry Smith (voice)", Episode = "Rick and Morty, Season 1: M. Night Shaym-Aliens!", Quote = "Well, all is forgiven, because right now, I’ve got an erection the size of an East Coast lighthouse, and I’m coming home to share it with my beautiful wife." },
                        new { Id = 94, Character = "Party-Goer", Episode = "Rick and Morty, Season 1: Ricksy Business", Quote = "And this is why you don't invite a Floopy Doop and a Shmoopy Doop to the same party." },
                        new { Id = 95, Character = "Rick Sanchez (voice)", Episode = "Rick and Morty, Season 1: Rick Potion #9", Quote = "Rick: Alright, Morty, I just gotta erhp combine it with some of your DNA.Morty: Oh well, okay. [unzips]Rick: A hair, Morty. I need one of your hairs. This isn't Game of Thrones." },
                        new { Id = 96, Character = "Rick Sanchez", Episode = "Rick and Morty, Season 1: Raising Gazorpazorp", Quote = "60 for the resonator, and my grandson wants the sex robot." },
                        new { Id = 97, Character = "Summer Smith (voice)", Episode = "Rick and Morty, Season 2: The Ricks Must Be Crazy", Quote = "Summer: You know you're kind of a dick, right?Rick's Computer: My function is to 'keep Summer safe', not 'keep Summer being, like, totally stoked about, like, the general vibe, and stuff'. That's you, that's how you talk." }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}