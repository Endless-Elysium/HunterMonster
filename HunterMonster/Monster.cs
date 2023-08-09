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
            Speed -= Head.Speed;

            Physatk -= Head.Physatk;
            Wateratk -= Head.Wateratk;
            Fireatk -= Head.Firedef;
            Leafatk -= Head.Leafdef;
            Darkatk -= Head.Darkatk;

            Physdef -= Head.Physdef;
            Waterdef -= Head.Waterdef;
            Firedef -= Head.Firedef;
            Leafdef -= Head.Leafdef;
            UpdateReward(e);
        }

        private void ArmBreak(object sender, int e)
        {
            Arms.OnPartBreak -= ArmBreak;
            Speed -= Arms.Speed;

            Physatk -= Arms.Physatk;
            Wateratk -= Arms.Wateratk;
            Fireatk -= Arms.Firedef;
            Leafatk -= Arms.Leafdef;
            Darkatk -= Arms.Darkatk;

            Physdef -= Arms.Physdef;
            Waterdef -= Arms.Waterdef;
            Firedef -= Arms.Firedef;
            Leafdef -= Arms.Leafdef;
            UpdateReward(e);
        }

        private void BodyBreak(object sender, int e)
        {
            Body.OnPartBreak -= BodyBreak;
            Speed -= Body.Speed;

            Physatk -= Body.Physatk;
            Wateratk -= Body.Wateratk;
            Fireatk -= Body.Firedef;
            Leafatk -= Body.Leafdef;
            Darkatk -= Body.Darkatk;

            Physdef -= Body.Physdef;
            Waterdef -= Body.Waterdef;
            Firedef -= Body.Firedef;
            Leafdef -= Body.Leafdef;
            UpdateReward(e);
        }

        private void TailBreak(object sender, int e)
        {
            Tail.OnPartBreak -= TailBreak;
            Speed -= Head.Speed;

            Physatk -= Tail.Physatk;
            Wateratk -= Tail.Wateratk;
            Fireatk -= Tail.Firedef;
            Leafatk -= Tail.Leafdef;
            Darkatk -= Tail.Darkatk;

            Physdef -= Tail.Physdef;
            Waterdef -= Tail.Waterdef;
            Firedef -= Tail.Firedef;
            Leafdef -= Tail.Leafdef;
            UpdateReward(e);
        }


        private void UpdateReward(int e)
        {
            Reward += e;
        }
    }
}
