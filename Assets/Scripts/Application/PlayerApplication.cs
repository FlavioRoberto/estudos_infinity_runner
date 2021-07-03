using System;
using Assembly_CSharp.Assets.Scripts.Factory.Move;
using Assembly_CSharp.Assets.Scripts.Models;
using UnityEngine;

namespace Assembly_CSharp.Assets.Scripts.Application
{
    public class PlayerApplication : MonoBehaviour
    {
        public Animator Animator;
        public Projectile Projectille;
        public Transform FirePoint;
        public float Speed = 5;
        public float ForceJump = 10;
        public float ReloadTime = 2;
        private Player _player;

        void Start()
        {
            _player = new Player(Animator, Projectille, FirePoint, GetComponent<Rigidbody2D>(), Speed, ForceJump, ReloadTime);
        }

        void Update()
        {
            _player.Move();
        }

        void OnCollisionEnter2D(Collision2D collision)
        {
            _player.OnCollisionEnter(collision);
        }
    }
}
