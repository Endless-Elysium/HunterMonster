using HunterMonster_Combat;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HunterMonster_Combat
{
    internal class Monster : MonsterPart
    {
        public int RandomDamage { get; init; } = 0;





        private MonsterPart _head;
        private MonsterPart _arms;
        private MonsterPart _body;
        private MonsterPart _tail;

        public MonsterPart? Head
        {
            get { return _head; }
            set
            {
                _head = value;
                HP += _head.HP;
                Speed += _head.Speed;
                Physatk += _head.Physatk;
                Wateratk += _head.Wateratk;
                Fireatk += _head.Fireatk;
                Leafatk += _head.Leafatk;

                Physdef += _head.Physdef;
                Waterdef += _head.Waterdef;
                Firedef += _head.Firedef;
                Leafdef += _head.Leafdef;
            }
        }
        public MonsterPart? Arms 
        { 
            get {return _arms; } 
            set 
            {
                _arms = value;
                HP += _arms.HP;
                Speed += _arms.Speed;
                Physatk += _arms.Physatk;
                Wateratk += _arms.Wateratk;
                Fireatk += _arms.Fireatk;
                Leafatk += _arms.Leafatk;

                Physdef += _arms.Physdef;
                Waterdef += _arms.Waterdef;
                Firedef += _arms.Firedef;
                Leafdef += _arms.Leafdef;
            } 
        }
        public MonsterPart? Body {
            get {return _body; }
            set 
            {
                _body = value;
                HP += _body.HP;
                Speed += _body.Speed;
                Physatk += _body.Physatk;
                Wateratk += _body.Wateratk;
                Fireatk += _body.Fireatk;
                Leafatk += _body.Leafatk;

                Physdef += _body.Physdef;
                Waterdef += _body.Waterdef;
                Firedef += _body.Firedef;
                Leafdef += _body.Leafdef;
            } 
        }
        public MonsterPart? Tail 
        { 
            get { return _tail; } 
            set 
            {
                _tail = value;
                HP += _body.HP;
                Speed += _tail.Speed;
                Physatk += _tail.Physatk;
                Wateratk += _tail.Wateratk;
                Fireatk += _tail.Fireatk;
                Leafatk += _tail.Leafatk;

                Physdef += _tail.Physdef;
                Waterdef += _tail.Waterdef;
                Firedef += _tail.Firedef;
                Leafdef += _tail.Leafdef;
            } 
        }

        public int Reward;

        private void Update()
        {

        }


        public void AtkHead(int damage)
        {
            this.HP -= damage;
            _head.HP -= damage;
            if (_head.HP <= 0) HeadBreak(); 
        }

        public void AtkArm(int damage)
        {
            this.HP -= damage;
            _arms.HP -= damage;
            if (_arms.HP <= 0) ArmBreak();
        }
        public void AtkBody(int damage)
        {
            this.HP -= damage;
            _body.HP -= damage;
            if (_body.HP <= 0) BodyBreak();
        }
        public void AtkTail(int damage)
        {
            this.HP -= damage;
            _tail.HP -= damage;
            if (_tail.HP <= 0) TailBreak();
        }

        public Monster()
        {
            _head = new MonsterPart();
            _arms = new MonsterPart();
            _body = new MonsterPart();
            _tail = new MonsterPart();
        }

        private void HeadBreak()
        {
            Console.WriteLine($"{_head.Name} broke!");
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
            UpdateReward(_head.Bonus);
        }

        private void ArmBreak()
        {
            Console.WriteLine($"{_arms.Name} broke!");
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
            UpdateReward(_arms.Bonus);
        }

        private void BodyBreak()
        {
            Console.WriteLine($"{_body.Name} broke!");
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
            UpdateReward(_body.Bonus);
        }

        private void TailBreak()
        {
            Console.WriteLine($"{_tail.Name} broke!");
            Speed -= Tail.Speed;

            Physatk -= Tail.Physatk;
            Wateratk -= Tail.Wateratk;
            Fireatk -= Tail.Firedef;
            Leafatk -= Tail.Leafdef;
            Darkatk -= Tail.Darkatk;

            Physdef -= Tail.Physdef;
            Waterdef -= Tail.Waterdef;
            Firedef -= Tail.Firedef;
            Leafdef -= Tail.Leafdef;
            UpdateReward(_tail.Bonus);
        }


        private void UpdateReward(int e)
        {
            Console.WriteLine("UpdateReward");
            Reward += e;
        }
    }
}
