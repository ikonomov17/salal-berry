﻿namespace Main_Program
{
    public interface IActions
    {
        Enemy MainEnemy { get; set; }
        Hero MainHero { get; set; }

        void Attacked();
        void Battle();
        void Dodged(Creature one);
    }
}