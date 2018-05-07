using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Reviews {
    public static Dictionary<string, string[]> likes = new Dictionary<string, string[]>();
    public static Dictionary<string, string[]> neutrals = new Dictionary<string, string[]>();
    public static Dictionary<string, string[]> dislikes = new Dictionary<string, string[]>();

    private static string[] farmerLikes = {
        "“[deity] promises a world of corn! Everything will be corn! Praise be to them!”",
        "“I’d sacrifice my first born for more rainfall. Luckily, [deity] will give me some for free.”",
        "“[deity] promises that a hard day's work will be rewarded beyond measure. Now that I can get behind”",
        "“In the new world, corn will be more valuable than diamonds. REAL DIAMONDS! Hot dawg!”",
        "“I can’t wait for [deity]’s world of famous farmers! I'm gonna be on TV!”"
    };
    private static string[] farmerDislikes = {
        "“Who will buy my crops when [deity] ruins society?”",
        "“[deity], if my herd dies in your fiery maelstrom, I’ll sue you with one o' them fancy lawyer types!”",
        "“If [deity] splits the earth open, I dare say it will ruin my tomato patch!”",
        "“I’m just a simple farmer. Why would I drink blood when I've got perfectly good corn cider?”",
        "“If [deity] insists on crucifyin' all them mortals, who's gonna eat my creamed corn?”"
    };
    private static string[] farmerNeutrals = {
        "“Take your [deity] mumbo jumbo and get off my property!”",
        "“I had good crops last season. I’ll stick with my God, thank you.”",
        "“There’s nothing [deity] can give me that my crops can’t.”",
        "“I’m too busy praying for rain to worship [deity].”",
        "“I can read the weather forecast, but not much else. I’m not interested in your pamphlet.”"
    };
    private static string[] teenLikes = {
        "“You don’t get it, mom! I’ve given my life to [deity]”",
        "“Zoe Tanner thinks it’s so hot to worship [deity]. Sign me up!”", 
        "“Bruce Applegate thinks people that worship [deity] are cute. I can’t wait to join!”",
        "“[deity] promises the abolition of homework. I never knew world ending deities were so chill.”",
        "“I’m sick of your freakin’ chores, mom! I’m gonna go worship [deity]!”"
    };
    private static string[] teenDislikes = {
        "“Ugh. People that worship [deity] are such posers.”",
        "“Low-key, [deity] worshipers are so stuck up.”",
        "“People that worship [deity] think they’re sooooo cool.As if.”",
        "“Hello? Snob police? I’d like to report [deity] worshipers.”",
        "“I wouldn’t be caught DEAD with those [deity] jerks.”"
    };
    private static string[] teenNeutrals = {
        "“I love [deity], but my parents would kill me if I joined.”",
        "“Sorry, I have marching band practice all week.”",
        "“If Korin doesn’t endorse you, I don’t endorse you.”",
        "“There is no problem [deity] can solve that painting and self-expression can’t.”",
        "“Um, I should really ask my parents before joining.”"
    };
    private static string[] parentLikes = {
        "“My kid is the laughing stock of the whole cul-de-sac. [deity] will whip him into shape!”",
        "“I miss playing air guitar back in college. With [deity], I’ll be a kid again.”",
        "“Anybody who cuts me off on the highway will bleed at the hands of [deity].”",
        "“My boss thinks I’m a lazy worker? [deity] will show him hell.”",
        "“[deity], please teach my kid how to shut the hell up for five minutes.”"
    };
    private static string[] parentDislikes = {
        "“All this [deity] talk is just more lazy, millennial hubbub.”",
        "“Worship [deity]? And risk my 401k? You’re a nutjob!”",
        "“My kid said he doesn’t need to do homework if he worships [deity]. I told him to cut the capital C Crap!”",
        "“When I was a kid, our house didn’t even have a roof. I didn’t need no stinkin’ [deity] to get my butt in gear!”",
        "“Attend a[deity] sermon? Yeah right! I got work in the morning, ya bum!”"
    };
    private static string[] parentNeutrals = {
        "“The PTA suggested we stay away from this organization.”",
        "“Membership fee? I’ll just stay home, thanks.”",
        "“I need a babysitter, not religion.”",
        "“Our couple’s therapist said cults are unhealthy for our marriage.”",
        "“I’m trying to enjoy my smoke break. Buzz off.”",
    };
    private static string[] elderLikes = {
        "“This old sack of bones could really use [deity]’s promised tranquility.”",
        "“This old chunk o’ coal just wants to lounge all day. [deity] can give me that.”",
        "“This old walking prune doesn’t want to worry about his blood pressure. [deity] will help!”",
        "“This wrinkled old bag misses her old appetite. [deity] can give it back to me.”",
        "“This wise old oak is sick of his colostomy bag! Help me, [deity]!”"
    };
    private static string[] elderDislikes = {
        "“I’ve seen enough baby booming for one lifetime. End [deity]’s sex cult!”",
        "“First short-shorts, now some sex god? Don’t let kids listen to this [deity] gobbledygook.”",
        "“Back in my day, we asked broads to the roller rink! Now, kids have whoopee for some corrupt, perv deity.”",
        "“America's gettin' worse by the day. [deity] proves that.”",
        "“Burn in hell, you deviants!”"
    };
    private static string[] elderNeutrals = {
        "“Please let me die in peace.”",
        "*This guy is dead*",
        "“I love my grandson. He turns 9 today. Such a good lad.”",
        "“Hello? Is this the Dollar store? What’s that? Huh? Join who? Huh? What’s that?”",
        "“Excuse me, I’ve forgotten where my house is.”"
    };
    private static string[] brewerLikes = {
        "“[deity] gets it, man! Society is for the narks!”",
        "“See? who needs an education when we’ve got [deity]! I love that... thing?”", 
        "“With [deity], all food is likely to be replaced with my microbrew! Praise be!”",
        "“[deity] said I can be the official craft brewer for the church!”",
        "“Craft beer will flood the streets! Death to the nonbelievers! Praise [deity]!”"
    };
    private static string[] brewerDislikes = {
        "“So [deity] is just gonna keep capitalism around? No thank you.”",
        "“I don’t care about the riches or power [deity] offers. What about the craft beer?”",
        "“If you ask me, it sounds like [deity] wants all the craft beer for himself. Craft beer is for the public!”",
        "“[deity] worshipers only care about themselves. Craft beer cannot flourish under their rule.”",
        "“[deity] worshipers are hoarding the craft beer. We microbrewers will not stand for this!”"
    };
    private static string[] brewerNeutrals = {
        "“Worship [deity]? Eh. Nah.”",
        "“Yous ish… I wan in…. bye-bye.”",
        "“Can’t join, bro. Gotta do a keg stand on the lazy river tonight.”",
        "“Not BYOB? Not interested.”",
        "“No thanks. I have a reputation to maintain.”"
    };
    private static string[] poliLikes = {
        "“[deity] says everything I touch will turn to gold. How cool is that?”",
        "“Under [deity], I will become the sovereign of this aimless universe!”",
        "“[deity] said he’d give me a better jawline. What a career-defining day this is!”",
        "“With [deity] in my corner, there’s no way I can lose my re-election campaign!”",
        "“[deity] is fully in support of open marriages. No scandal for me!”"
    };
    private static string[] poliDislikes = {
        "“According to our sources, [deity] is fake news and should not be trusted.”",
        "“I’ve seen the tapes! [deity] smokes marijuana! Hang the cretin!”",
        "“Let’s leave the 60s in the 60s. [deity] is a countercultural terrorist!”",
        "“And how does [deity] plan to finance this eternal peace? They better not be taking from our troops!”",
        "“We need more battleships, not some leftist, [deity] hocus pocus!”"
    };
    private static string[] poliNeutrals = {
        "“Sounds nice, but I don’t have time to fit [deity] into my platform.”",
        "“No thanks. The Autocratic structure of your church doesn’t interest me.”",
        "“I have no comment regarding [deity] at this time.”",
        "“I’d love to join, but it could cause a horrible scandal.”",
        "“Sorry, buddy. Don’t want to risk the cash I’m making with my current gig.”"
    };
    private static string[] prepperLikes = {
        "“And people said I was crazy. Just wait til they hear about my new god!”",
        "“I’M the crazy one?! I’ll be the one laughing when [deity] kills your kids.”",
        "“If [deity] destroys the earth, maybe my parents will finally visit my bunker.”",
        "“I hear [deity] is fully in support of my 2nd amendment rights!”",
        "“Imagine. Insipid beggars. Pleading to enter my bunker. Lives of self-importance and cruelty. Extinguished by [deity].”"
    };
    private static string[] prepperDislikes = {
        "“Even my dying niece could survive [deity]’s apocalypse. I don’t buy it.”",
        "“What a bunch of bull. There’s a different apocalypse happening way before [deity]’s.”", 
        "“Why does EVERYBODY go to heaven after the apocalypse when I’M the only one who prepared for it?”",
        "“[deity] says CHILDREN will survive the APOCALYPSE? What a FRAUD!”",
        "“Where’s the apocalypse? You can’t have a religion without an apocalypse!”"
    };
    private static string[] prepperNeutrals = {
        "“[deity]? It’s a bit farfetched, don’t you think?”",
        "“I can’t follow[deity]’s beliefs.My book club would think I’m crazy.”",
        "“Cool concept, but not my flavor of apocalypse, ya know?”",
        "“I ain’t joining an organization that doesn’t arm every man, woman, and child.”",
        "“[deity]? Yeah right.You’re probably just some cult.”"
    };

    public static void GenerateReviews()
    {
        likes = new Dictionary<string, string[]>();
        dislikes = new Dictionary<string, string[]>();
        neutrals = new Dictionary<string, string[]>();
        likes.Add("Maize Farmers", farmerLikes);
        likes.Add("Rowdy Teens", teenLikes);
        likes.Add("Busy Parents", parentLikes);
        likes.Add("Haughty Elders", elderLikes);
        likes.Add("Microbrewers", brewerLikes);
        likes.Add("Alt-right Politicians", poliLikes);
        likes.Add("Doomsday Preppers", prepperLikes);
        dislikes.Add("Maize Farmers", farmerDislikes);
        dislikes.Add("Rowdy Teens", teenDislikes);
        dislikes.Add("Busy Parents", parentDislikes);
        dislikes.Add("Haughty Elders", elderDislikes);
        dislikes.Add("Microbrewers", brewerDislikes);
        dislikes.Add("Alt-right Politicians", poliDislikes);
        dislikes.Add("Doomsday Preppers", prepperDislikes);
        neutrals.Add("Maize Farmers", farmerNeutrals);
        neutrals.Add("Rowdy Teens", teenNeutrals);
        neutrals.Add("Busy Parents", parentNeutrals);
        neutrals.Add("Haughty Elders", elderNeutrals);
        neutrals.Add("Microbrewers", brewerNeutrals);
        neutrals.Add("Alt-right Politicians", poliNeutrals);
        neutrals.Add("Doomsday Preppers", prepperNeutrals);
    }

    public static void SetReviews(string harbinger)
    {
        foreach (Demographic d in CultController.controller.demographics)
        {
            for (int i = 0; i < 5; i++)
            {
                likes[d.name][i] = likes[d.name][i].Replace("[deity]", harbinger);
                dislikes[d.name][i] = dislikes[d.name][i].Replace("[deity]", harbinger);
                neutrals[d.name][i] = neutrals[d.name][i].Replace("[deity]", harbinger);
            }
        }
    }

    public static string GetReview (string demoName, int influenceChange)
    {
        if (influenceChange > 0)
        {
            return likes[demoName][Random.Range(0,5)] + " -" + demoName;
        }
        else if (influenceChange < 0)
        {
            return dislikes[demoName][Random.Range(0, 5)] + " -" + demoName;
        }
        else
        {
            return neutrals[demoName][Random.Range(0, 5)] + " -" + demoName;
        }
    }
}
