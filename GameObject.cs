﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameFramework
{
    public class GameObject
    {
        private int speed;
        PictureBox gameElement = new PictureBox();
        public IMovement direction;
        public ObjectsType type;

        internal GameObject(PictureBox gameElement, int speed, IMovement direction, ObjectsType type)
        {
            this.speed = speed;
            this.gameElement = gameElement;
            this.gameElement.BackColor = Color.Transparent;
            this.direction = direction;
            this.type = type;
        }

        internal GameObject(PictureBox gameElement, int speed, ObjectsType type)
        {
            this.speed = speed;
            this.gameElement = gameElement;
            this.gameElement.BackColor = Color.Transparent;
            this.direction = new MoveLeft();
            this.type = type;
        }

        public void Disappear()
        {
            this.gameElement.Hide();
            GC.Collect(GC.GetGeneration(this));
        }

        public PictureBox getPicture()
        {
            return gameElement;
        }

        public void UpdatePosition()
        {
            this.direction.Move(this.gameElement, this.speed);
        }

        ~GameObject()
        {
            MovementPool PollObj = MovementPool.getOnePool();
            PollObj.Release(this.direction);
        }
    }
}