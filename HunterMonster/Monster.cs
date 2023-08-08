using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HunterMonster
{
    internal class Monster : MonsterPart
    {
        
        public MonsterPart Head { get; init; }
        public MonsterPart Arms { get; init; }
        public MonsterPart Body { get; init; }
        public MonsterPart Tail { get; init; }
        public int Reward;

        public Monster()
        {
            if (Head == null || Arms == null || Body == null || Tail == null)
            {
                Head = new MonsterPart();
                Arms = new MonsterPart();
                Body = new MonsterPart();
                Tail = new MonsterPart();
            }

            HP =+ Head.HP + Arms.HP + Body.HP + Tail.HP - ((Head.HP + Arms.HP + Body.HP + Tail.HP) / 4);
            Speed = Head.Speed + Body.Speed + Tail.Speed;

            Physatk = Head.Physatk + Arms.Physatk + Body.Physatk + Tail.Physatk;
            Wateratk = Head.Wateratk + Arms.Wateratk + Body.Wateratk + Tail.Wateratk;
            Fireatk = Head.Fireatk + Arms.Fireatk + Body.Fireatk + Tail.Fireatk;
            Leafatk = Head.Leafatk + Arms.Leafatk + Body.Leafatk + Tail.Leafatk;
            Darkatk = Head.Darkatk + Arms.Darkatk + Body.Darkatk + Tail.Darkatk;

            Physdef = Head.Physdef + Arms.Physdef + Body.Physdef + Tail.Physdef;
            Waterdef = Head.Waterdef + Arms.Waterdef + Body.Waterdef + Tail.Waterdef;
            Firedef = Head.Firedef + Arms.Firedef + Body.Firedef + Tail.Firedef;
            Leafdef = Head.Leafdef + Arms.Leafdef + Body.Leafdef + Tail.Leafdef;

            Head.OnPartBreak += HeadBreak;
            Arms.OnPartBreak += ArmBreak;
            Body.OnPartBreak += BodyBreak;
            Tail.OnPartBreak += TailBreak;
        }
        
        private void HeadBreak(object sender, int e)
        {
            Head.OnPartBreak -= HeadBreak;
            UpdateReward(e);
        }

        private void ArmBreak(object sender, int e)
        {
            Arms.OnPartBreak -= ArmBreak;
            UpdateReward(e);
        }

        private void BodyBreak(object sender, int e)
        {
            Body.OnPartBreak -= BodyBreak;
            UpdateReward(e);
        }

        private void TailBreak(object sender, int e)
        {
            Tail.OnPartBreak -= TailBreak;
            UpdateReward(e);
        }


        private void UpdateReward(int e)
        {
            Reward += e;
        }
    }
}
