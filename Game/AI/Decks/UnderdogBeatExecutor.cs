using YGOSharp.OCGWrapper.Enums;
using System.Collections.Generic;
using WindBot;
using WindBot.Game;
using WindBot.Game.AI;


namespace WindBot.Game.AI.Decks
{
    [Deck("UnderdogBeat", "AI_UnderdogBeat", "NotFinished")]
    public class UnderdogBeatExecutor : DefaultExecutor
    {
        public class CardId
        {
            public const int SummonedSkull = 70781052;
            public const int MegalosmasherX = 81823360;
            public const int LusterDragon = 11091375;
            public const int InsectKnightl = 35052053;
            public const int GladiatorBeastAndall = 90582719;
            public const int MadDogofDarkness = 79182538;
            public const int GeminiElfl = 69140098;
            public const int Sabersaurus = 37265642;


            public const int SuperRushHeadlong = 48422921;
            public const int EnemyController = 98045062;
            public const int HeartoftheUnderdog = 35762283;
            public const int HalfCounter = 6799227;
            public const int WallofDisruptionr = 58169731;
            public const int MirrorWall = 22359980;
        }

        public UnderdogBeatExecutor(GameAI ai, Duel duel)
            : base(ai, duel)
        {
            AddExecutor(ExecutorType.Summon, CardId.SummonedSkull);
            AddExecutor(ExecutorType.Summon, CardId.MegalosmasherX);
            AddExecutor(ExecutorType.Summon, CardId.LusterDragon);
            AddExecutor(ExecutorType.Summon, CardId.InsectKnightl);
            AddExecutor(ExecutorType.Summon, CardId.GladiatorBeastAndall);
            AddExecutor(ExecutorType.Summon, CardId.MadDogofDarkness);
            AddExecutor(ExecutorType.Summon, CardId.GeminiElfl);
            AddExecutor(ExecutorType.Summon, CardId.Sabersaurus);

            AddExecutor(ExecutorType.Activate, CardId.HeartoftheUnderdog);

            AddExecutor(ExecutorType.SpellSet, CardId.EnemyController);
            AddExecutor(ExecutorType.Activate, CardId.EnemyController);

            AddExecutor(ExecutorType.SpellSet, CardId.SuperRushHeadlong);
            AddExecutor(ExecutorType.Activate, CardId.SuperRushHeadlong);

            AddExecutor(ExecutorType.SpellSet, CardId.HalfCounter);
            AddExecutor(ExecutorType.Activate, CardId.HalfCounter);

            AddExecutor(ExecutorType.SpellSet, CardId.WallofDisruptionr);
            AddExecutor(ExecutorType.Activate, CardId.WallofDisruptionr);

            AddExecutor(ExecutorType.SpellSet, CardId.MirrorWall);
            AddExecutor(ExecutorType.Activate, CardId.MirrorWall);

        }

    }
}