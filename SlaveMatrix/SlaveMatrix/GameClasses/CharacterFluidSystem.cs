using _2DGAMELIB;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlaveMatrix.GameClasses
{
    internal class CharacterFluidSystem
    {
        private readonly Character owner;
        private readonly Body body;
        private readonly CharacterData data;
        private readonly Motions motions;

        private Motion urineStage1;
        private Motion urineStage2;
        private Motion urineStain;
        private Motion urineSteam;

        public Motion MouthCumDrip { get; private set; }
        public Motion GenitalCumDrip { get; private set; }
        public Motion AnalCumDrip { get; private set; }
        public Motion ThreadCumDrip { get; private set; }
        public Motion SquirtSmall { get; private set; }
        public Motion SquirtLarge { get; private set; }
        public Motion Splash { get; private set; }
        public Motion SpitSplash { get; private set; }
        public Motion Urination { get; private set; }
        public Motion MilkSpray { get; private set; }
        public double MilkStain { get; private set; }
        public Motion NoseDrip { get; private set; }
        public Motion Drool { get; private set; }

        public bool IsUrinating => Urination.Run || urineStage1.Run || urineStage2.Run;

        public CharacterFluidSystem(Character owner, Body body, CharacterData data, Motions motions)
        {
            this.owner = owner;
            this.body = body;
            this.data = data;
            this.motions = motions;
        }

        public void Initialize()
        {
            CreateNoseDrip();
            CreateDrool();
            CreateSplash();
            CreateSpitSplash();
        }

        private void Register(string key, Motion motion)
        {
            motions.Add(key, motion);
        }

        private bool CanUpdateSingleDrip(涎 left, 涎 right)
        {
            bool leftOk = left == null || left.Yv != 1.0;
            bool rightOk = right == null || right.Yv != 1.0;
            return leftOk && rightOk;
        }

        private bool CanUpdateSingleDrip(鼻水 left, 鼻水 right)
        {
            bool leftOk = left == null || left.Yv != 1.0;
            bool rightOk = right == null || right.Yv != 1.0;
            return leftOk && rightOk;
        }
        private void CreateNoseDrip()
        {
            bool useLeftNose = false;
            bool hasLeft = body.LeftNoseDrip != null;
            bool hasRight = body.RightNoseDrip != null;

            NoseDrip = new Motion(0.0, 1.0)
            {
                BaseSpeed = 3.0,
                OnStart = delegate
                {
                    useLeftNose = RNG.XS.NextBool();

                    if (!CanUpdateSingleDrip(body.LeftNoseDrip, body.RightNoseDrip))
                        return;

                    if (useLeftNose)
                    {
                        if (hasLeft)
                        {
                            body.LeftNoseDrip.Yv = 0.0;
                            body.LeftNoseDrip.表示 = true;
                        }
                    }
                    else
                    {
                        if (hasRight)
                        {
                            body.RightNoseDrip.Yv = 0.0;
                            body.RightNoseDrip.表示 = true;
                        }
                    }
                },
                OnUpdate = delegate (Motion m)
                {
                    if (!CanUpdateSingleDrip(body.LeftNoseDrip, body.RightNoseDrip))
                        return;

                    if (useLeftNose)
                    {
                        if (hasLeft)
                            body.LeftNoseDrip.Yv = m.Value;
                    }
                    else
                    {
                        if (hasRight)
                            body.RightNoseDrip.Yv = m.Value;
                    }
                },
                OnReach = delegate (Motion m)
                {
                    m.End();
                },
                OnLoop = delegate
                {
                },
                OnEnd = delegate
                {
                }
            };

            Register(NoseDrip.GetHashCode().ToString(), NoseDrip);
        }
    
        private void CreateDrool()
        {
            bool useLeftDrool = false;
            bool hasLeft = body.LeftDrool != null;
            bool hasRight = body.RightDrool != null;

            Drool = new Motion(0.0, 1.0)
            {
                BaseSpeed = 3.0,
                OnStart = delegate
                {
                    useLeftDrool = RNG.XS.NextBool();

                    if (!CanUpdateSingleDrip(body.LeftDrool, body.RightDrool))
                        return;

                    if (useLeftDrool)
                    {
                        if (hasLeft)
                        {
                            body.LeftDrool.Yv = 0.0;
                            body.LeftDrool.表示 = true;
                        }
                    }
                    else
                    {
                        if (hasRight)
                        {
                            body.RightDrool.Yv = 0.0;
                            body.RightDrool.表示 = true;
                        }
                    }
                },
                OnUpdate = delegate (Motion m)
                {
                    if (!CanUpdateSingleDrip(body.LeftDrool, body.RightDrool))
                        return;

                    if (useLeftDrool)
                    {
                        if (hasLeft)
                            body.LeftDrool.Yv = m.Value;
                    }
                    else
                    {
                        if (hasRight)
                            body.RightDrool.Yv = m.Value;
                    }
                },
                OnReach = delegate (Motion m)
                {
                    m.End();
                },
                OnLoop = delegate
                {
                },
                OnEnd = delegate
                {
                }
            };

            Register(Drool.GetHashCode().ToString(), Drool);
        }
   
        private void CreateSplash()
        {
            Splash = new Motion(0.0, 1.0)
            {
                BaseSpeed = 4.0,

                OnStart = delegate
                {
                    body.Splash.Yv = 0.0;
                    body.Splash.表示 = true;
                    body.Splash.右 = RNG.XS.NextBool();
                },
                OnUpdate = delegate (Motion m)
                {
                    body.Splash.Yv = m.Value;
                },
                OnReach = delegate (Motion m)
                {
                    m.End();
                },
                OnLoop = delegate
                {
                },
                OnEnd = delegate
                {
                    body.Splash.表示 = false;
                    body.SplashIntencity = (body.SplashIntencity + 0.03).Clamp(0.0, 1.0);
                }
            };

            Register(Splash.GetHashCode().ToString(), Splash);
        }
    
        private void CreateSpitSplash()
        {
            SpitSplash = new Motion(0.0, 1.0)
            {
                BaseSpeed = 3.0,

                OnStart = delegate
                {
                    body.咳.Yv = 0.0;
                    body.咳.表示 = true;
                },
                OnUpdate = delegate (Motion m)
                {
                    body.咳.Yv = m.Value;
                },
                OnReach = delegate (Motion m)
                {
                    m.End();
                },
                OnLoop = delegate
                {
                },
                OnEnd = delegate
                {
                    body.咳.表示 = false;
                }
            };

            Register(SpitSplash.GetHashCode().ToString(), SpitSplash);
        }
    }
}
