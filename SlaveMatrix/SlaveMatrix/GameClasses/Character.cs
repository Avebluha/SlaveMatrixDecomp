using _2DGAMELIB;
using SlaveMatrix.GameClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;

namespace SlaveMatrix
{
    public class Character
    {
        private sealed class BodyPartRef
        {
            public ElementInstance EI;
            public bool Heavy;

            public BodyPartRef(ElementInstance ei, bool heavy)
            {
                this.EI = ei;
                this.Heavy = heavy;
            }
        }

        private CharacterFluidSystem fluids;

        private List<BodyPartRef> _moveParts;
        private List<BodyPartRef> _contParts;

        public ModeEventDispatcher ModeEventDispatcher;

    	public RenderArea RenderArea;

    	public Body Body;

    	public CharacterData CharacterData;

    	public BodyColorSet ColorSet;

    	public double FPS;

    	public Vector2D CursorPosition;

    	private Motion Breathing;

    	private double BaseBreathingSpeed;

    	private Motion TearFlow;

    	private Motion TearFade;

    	private bool 泣き_;

    	private Motion BlinkMain;

    	private Motion BlinkExtra;

    	public Motion 汗かき;

    	public Motion MouthCumDrip;

    	public Motion GenitalCumDrip;

    	public Motion AnalCumDrip;

    	public Motion ThreadCumDrip;

    	public Motion SquirtSmall;

    	public Motion SquirtLarge;

    	public Motion Splash => fluids.Splash;

    	public Motion SpitSplash => fluids.SpitSplash;

    	public Motion Urination;

    	public Action 放尿強制終了_ = delegate
    	{
    	};

    	public Func<bool> IsUrinating = () => false;

    	public Motion MilkSpray;

    	public double MilkStain;

    	public Motion NoseDrip => fluids.NoseDrip;

    	public Motion Drool => fluids.Drool;

    	public Motion EyeTracking;

    	public bool LookAway;

    	public double ClimaxIntensity;

    	public double ClimaxDuration;

    	public Motion ClimaxEnd;

    	public Motion Climax;

    	public Motion 肛ヒク;

    	public Motion 膣ヒク;

    	public Motion 糸ヒク;

    	public Motion 顔面展開;

    	public Motion BodySway;

    	public Motion Cough;

    	public Motion Swallow;

    	private Sweat 汗掻き;

    	public double 瞼基準単;

    	public double 瞼基準左;

    	public double 瞼基準右;

    	public double 瞼基準額;

    	public double 瞼基準頬左;

    	public double 瞼基準頬右;

    	public Action 潮吹擬音;

    	public Action 放尿擬音;

    	private double 呼吸_;

    	private double y;

    	private bool 重髪;

    	private bool 重耳;

    	private bool 重胸;

    	private bool 重Waist;

    	private bool 重腕前;

    	private bool 重半後;

    	private bool 重半中1;

    	private bool 重半中2;

    	private bool 重半前;

    	private bool 重腿;

    	private Vector2D p = DataConsts.Vec2DZero;

        private delegate void MorphMotion(double value);

        private List<MorphMotion> _morphMotions;
        private List<MorphMotion> _morphMotionsBodySway;

    	public Motions Motions = new Motions();

        private void InitMorphMotions()
        {
            _morphMotions = new List<MorphMotion>(32);
            _morphMotionsBodySway = new List<MorphMotion>(32);

            if (Body.Arm人n > 0)
            {
                _morphMotions.Add(this.腕人絶頂);
                _morphMotionsBodySway.Add(this.腕人絶頂);
            }

            if (Body.腕翼鳥n > 0)
            {
                _morphMotions.Add(this.腕翼鳥絶頂);
                _morphMotionsBodySway.Add(this.腕翼鳥絶頂);
            }

            if (Body.腕翼獣n > 0)
            {
                _morphMotions.Add(this.腕翼獣絶頂);
                _morphMotionsBodySway.Add(this.腕翼獣絶頂);
            }

            if (Body.腕獣n > 0)
            {
                _morphMotions.Add(this.腕獣絶頂);
                _morphMotionsBodySway.Add(this.腕獣絶頂);
            }

            if (Body.Is触覚他)
            {
                _morphMotions.Add(this.触覚絶頂);
                _morphMotionsBodySway.Add(this.触覚絶頂);
            }

            if (Body.Is触覚甲)
            {
                _morphMotions.Add(this.触覚甲絶頂);
                _morphMotionsBodySway.Add(this.触覚甲絶頂);
            }

            if (Body.大顎n > 0)
            {
                _morphMotions.Add(this.大顎絶頂);
                _morphMotionsBodySway.Add(this.大顎絶頂);
            }

            if (Body.虫顎n > 0)
            {
                _morphMotions.Add(this.虫顎絶頂);
                _morphMotionsBodySway.Add(this.虫顎絶頂);
            }

            if (Body.鰭n > 0)
            {
                _morphMotions.Add(this.鰭絶頂);
                _morphMotionsBodySway.Add(this.鰭絶頂);
            }

            if (Body.葉n > 0)
            {
                _morphMotions.Add(this.葉絶頂);
                _morphMotionsBodySway.Add(this.葉絶頂);
            }

            if (Body.前翅1n > 0)
            {
                _morphMotions.Add(this.前翅絶頂);
                _morphMotionsBodySway.Add(v => this.前翅絶頂(-v));
            }

            if (Body.後翅1n > 0)
            {
                _morphMotions.Add(this.後翅絶頂);
                _morphMotionsBodySway.Add(v => this.後翅絶頂(-v));
            }

            if (Body.触肢蜘n > 0)
            {
                _morphMotions.Add(this.触肢蜘絶頂);
                _morphMotionsBodySway.Add(this.触肢蜘絶頂);
            }

            if (Body.触肢蠍n > 0)
            {
                _morphMotions.Add(this.触肢蠍絶頂);
                _morphMotionsBodySway.Add(this.触肢蠍絶頂);
            }

            if (Body.節足蜘n > 0)
            {
                _morphMotions.Add(this.節足蜘絶頂);
                _morphMotionsBodySway.Add(this.節足蜘絶頂);
            }

            if (Body.節足蠍n > 0)
            {
                _morphMotions.Add(this.節足蠍絶頂);
                _morphMotionsBodySway.Add(this.節足蠍絶頂);
            }

            if (Body.節足百n > 0)
            {
                _morphMotions.Add(this.節足百絶頂);
                _morphMotionsBodySway.Add(this.節足百絶頂);
            }

            if (Body.節尾曳n > 0)
            {
                _morphMotions.Add(this.節尾曳絶頂);
                _morphMotionsBodySway.Add(this.節尾曳絶頂);
            }

            if (Body.節尾鋏n > 0)
            {
                _morphMotions.Add(this.節尾鋏絶頂);
                _morphMotionsBodySway.Add(this.節尾鋏絶頂);
            }

            if (Body.虫鎌n > 0)
            {
                _morphMotions.Add(this.虫鎌絶頂);
                _morphMotionsBodySway.Add(this.虫鎌絶頂);
            }

            if (Body.触手n > 0)
            {
                _morphMotions.Add(this.触手絶頂);
                _morphMotionsBodySway.Add(this.触手絶頂);
            }

            if (Body.触手犬n > 0)
            {
                _morphMotions.Add(this.触手犬絶頂);
                _morphMotionsBodySway.Add(this.触手犬絶頂);
            }

            if (Body.尾n > 0)
            {
                _morphMotions.Add(this.尾絶頂);
                _morphMotionsBodySway.Add(this.尾絶頂);
            }

            if (Body.Is植)
            {
                _morphMotions.Add(this.植絶頂);
                _morphMotionsBodySway.Add(this.植絶頂);
            }

            if (Body.脚人n > 0)
            {
                _morphMotions.Add(this.脚人絶頂);
                _morphMotionsBodySway.Add(this.脚人絶頂);
            }

            if (Body.脚獣n > 0)
            {
                _morphMotions.Add(this.脚獣絶頂);
                _morphMotionsBodySway.Add(this.脚獣絶頂);
            }
        }
        private void ApplyMorphMotions(double value, bool invertWingForBoddySway)
        {
            List<MorphMotion> list = invertWingForBoddySway ? _morphMotions : _morphMotionsBodySway;

            for (int i = 0; i < list.Count; i++)
                list[i](value);
        }
        private void ApplyMoveParts(Vector2D offset)
        {
            for (int i = 0; i < _moveParts.Count; i++)
            {
                var part = _moveParts[i];

                if (part.Heavy)
                    part.EI.Position = offset;
                else
                    part.EI.Updatef = true;
            }
        }
        private void ResetMoveParts()
        {
            for (int i = 0; i < _moveParts.Count; i++)            
                _moveParts[i].EI.Position = DataConsts.Vec2DZero;            
        }
        private void ApplyContParts(Vector2D offset)
        {
            for (int i = 0; i < _moveParts.Count; i++)
            {
                var part = _moveParts[i];

                if (part.Heavy)
                    part.EI.PositionCont = offset;
                else
                    part.EI.Updatef = true;
            }
        }
        private void ResetContParts()
        {
            for (int i = 0; i < _moveParts.Count; i++)
                _moveParts[i].EI.PositionCont = DataConsts.Vec2DZero;
        }
        public double BreathingSpeed
    	{
    		get
    		{
    			return BaseBreathingSpeed;
    		}
    		set
    		{
    			BaseBreathingSpeed = value;
    			Breathing.BaseSpeed = 6.0 * BaseBreathingSpeed;
    		}
    	}
    	public bool Crying
    	{
    		get
    		{
    			return 泣き_;
    		}
    		set
    		{
    			泣き_ = value;
    			if (!泣き_)
    			{
    				TearFade.Start();
    			}
    		}
    	}
    	public double BreathingValue
    	{
    		get
    		{
    			return 呼吸_;
    		}
    		set
    		{
    			呼吸_ = value;
    			Body.Chest.尺度C = 0.99 + 0.02 * 呼吸_;
    			Body.胸肌_人.尺度C = Body.Chest.尺度C;
    			p.Y = y * 呼吸_ * 0.5;
    			if (Body.Is髪)
    			{
    				Body.EI髪.Position = p;
    			}
    			if (Body.Is腕前)
    			{
    				Body.EI腕前.Position = p;
    			}
    			p.Y = y * 呼吸_ * 0.28;
    			if (Body.IsChest)
    			{
    				Body.EIChest.Position = p;
    			}
    			p.Y = 0.0 - p.Y;
    			Body.Waist.位置C = p;
    			if (Body.IsWaist)
    			{
    				Body.EIWaist.Position = p;
    			}
    			if (Body.Is半後)
    			{
    				Body.EI半後.Position = p;
    			}
    			if (Body.Is半中1)
    			{
    				Body.EI半中1.Position = p;
    			}
    			if (Body.Is半中2)
    			{
    				Body.EI半中2.Position = p;
    			}
    			if (Body.Is半前)
    			{
    				Body.EI半前.Position = p;
    			}
    			if (Body.Is腿)
    			{
    				Body.EI腿.Position = p;
    			}
    		}
    	}
    	public double InternalCumLevel
    	{
    		get
    		{
    			if (Body.カーソル != null)
    			{
    				return (1.0 / (double)(Body.カーソル.ペニス処理.中出しCount + 1)).Inverse();
    			}
    			return 0.0;
    		}
    	}
    	public void 放尿強制終了()
    	{
    		放尿強制終了_();
    	}

    	public Character(ModeEventDispatcher Med, RenderArea Are, CharacterData ChaD)
    	{
    		Character cha = this;
    		this.ModeEventDispatcher = Med;
    		this.RenderArea = Are;
    		this.CharacterData = ChaD;
    		ColorSet = new BodyColorSet(ChaD.body_color);
    		_ = Are.DisplayUnitScale;
    		Body = new Body(Med, Are, this);

            fluids = new CharacterFluidSystem(this, Body, ChaD, Motions);
            fluids.Initialize(); 

            InitMorphMotions();

    		重髪 = Body.Is髪 && Body.EI髪.IsHeavy();
    		重胸 = Body.IsChest && Body.EIChest.IsHeavy();
    		重Waist = Body.IsWaist && Body.EIWaist.IsHeavy();
    		重腕前 = Body.Is腕前 && Body.EI腕前.IsHeavy();
    		重半後 = Body.Is半後 && Body.EI半後.IsHeavy();
    		重半中1 = Body.Is半中1 && Body.EI半中1.IsHeavy();
    		重半中2 = Body.Is半中2 && Body.EI半中2.IsHeavy();
    		重半前 = Body.Is半前 && Body.EI半前.IsHeavy();
    		重腿 = Body.Is腿 && Body.EI腿.IsHeavy();

            _moveParts = new List<BodyPartRef>(9);
            _contParts = new List<BodyPartRef>(6);

            if (Body.Is髪) _moveParts.Add(new BodyPartRef(Body.EI髪, 重髪));
            if (Body.IsChest) _moveParts.Add(new BodyPartRef(Body.EIChest, 重胸));
            if (Body.IsWaist) _moveParts.Add(new BodyPartRef(Body.EIWaist, 重Waist));
            if (Body.Is腕前) _moveParts.Add(new BodyPartRef(Body.EI腕前, 重腕前));
            if (Body.Is半後) _moveParts.Add(new BodyPartRef(Body.EI半後, 重半後));
            if (Body.Is半中1) _moveParts.Add(new BodyPartRef(Body.EI半中1, 重半中1));
            if (Body.Is半中2) _moveParts.Add(new BodyPartRef(Body.EI半中2, 重半中2));
            if (Body.Is半前) _moveParts.Add(new BodyPartRef(Body.EI半前, 重半前));
            if (Body.Is腿) _moveParts.Add(new BodyPartRef(Body.EI腿, 重腿));

            if (Body.IsWaist) _contParts.Add(new BodyPartRef(Body.EIWaist, 重Waist));
            if (Body.Is半後) _contParts.Add(new BodyPartRef(Body.EI半後, 重半後));
            if (Body.Is半中1) _contParts.Add(new BodyPartRef(Body.EI半中1, 重半中1));
            if (Body.Is半中2) _contParts.Add(new BodyPartRef(Body.EI半中2, 重半中2));
            if (Body.Is半前) _contParts.Add(new BodyPartRef(Body.EI半前, 重半前));
            if (Body.Is腿) _contParts.Add(new BodyPartRef(Body.EI腿, 重腿));

            double 尺度C = Body.Chest.尺度C;
    		Body.Chest.尺度C = 0.99;
    		double num = Body.Chest.X0Y0_RibCage.ToGlobal(Body.Chest.X0Y0_RibCage.GetJP()[0].Joint).Y;
    		Body.Chest.尺度C = 1.01;
    		double num2 = Body.Chest.X0Y0_RibCage.ToGlobal(Body.Chest.X0Y0_RibCage.GetJP()[0].Joint).Y;
    		Body.Chest.尺度C = 尺度C;
    		y = num2 - num;
    		Breathing = new Motion(0.0, 1.0)
    		{
    			LowestIncrease = 0.25,
    			BaseSpeed = 6.0 * BaseBreathingSpeed,
    			OnStart = delegate
    			{
    				cha.Body.呼気.Intensity = 0.0;
    				cha.Body.呼気.表示 = true;
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				cha.Body.呼気.Intensity = m.Value.Inverse() * cha.BaseBreathingSpeed;
    				cha.BreathingValue = m.Value;
    			},
    			OnReach = delegate
    			{
    			},
    			OnLoop = delegate
    			{
    			},
    			OnEnd = delegate
    			{
    				cha.Body.呼気.表示 = false;
    				cha.Body.呼気.Intensity = 1.0;
    				cha.BreathingValue = 0.0;
    			}
    		};
    		Motions.Add(Breathing.GetHashCode().ToString(), Breathing);
    		BreathingSpeed = 0.2;
    		Breathing.Start();
    		bool IsTearFlow = true;
    		bool LeftTear = Body.LeftTear != null;
    		bool RightTear = Body.RightTear != null;
    		TearFlow = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 3.0,
    			OnStart = delegate
    			{
    				IsTearFlow = true;
    				if (LeftTear)
    				{
    					if (cha.Body.IsDualEyes)
    					{
    						cha.Body.目左.黒目_ハイライト下_表示 = true;
    					}
    					if (cha.Body.IsCheekEyes)
    					{
    						cha.Body.頬目左.黒目_ハイライト下_表示 = true;
    					}
    					if (cha.Body.IsSingleEye)
    					{
    						cha.Body.単眼目.黒目_ハイライト下_表示 = true;
    					}
    					if (cha.Body.IsForeheadEye)
    					{
    						cha.Body.額目.黒目_ハイライト下_表示 = true;
    					}
    					cha.Body.LeftTear.Tear0流れ0_表示 = cha.Body.LeftTear.Tear0流れ1_表示 || cha.Body.LeftTear.Tear0_表示;
    					cha.Body.LeftTear.Tear0流れ1_表示 = cha.Body.LeftTear.Tear0_表示;
    					cha.Body.LeftTear.Tear0_表示 = !cha.Body.LeftTear.Tear0_表示;
    					cha.Body.LeftTear.Tearハイライト_表示 = cha.Body.LeftTear.Tear0_表示;
    					cha.Body.LeftTear.Yv = 0.0;
    					cha.Body.LeftTear.Tear0流れ1CD.不透明度 = 1.0;
    				}
    				if (RightTear)
    				{
    					if (cha.Body.IsDualEyes)
    					{
    						cha.Body.目右.黒目_ハイライト下_表示 = true;
    					}
    					if (cha.Body.IsCheekEyes)
    					{
    						cha.Body.頬目右.黒目_ハイライト下_表示 = true;
    					}
    					cha.Body.RightTear.Tear0流れ0_表示 = cha.Body.RightTear.Tear0流れ1_表示 || cha.Body.RightTear.Tear0_表示;
    					cha.Body.RightTear.Tear0流れ1_表示 = cha.Body.RightTear.Tear0_表示;
    					cha.Body.RightTear.Tear0_表示 = !cha.Body.RightTear.Tear0_表示;
    					cha.Body.RightTear.Tearハイライト_表示 = cha.Body.RightTear.Tear0_表示;
    					cha.Body.RightTear.Yv = 0.0;
    					cha.Body.RightTear.Tear0流れ1CD.不透明度 = 1.0;
    				}
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				if (IsTearFlow)
    				{
    					if (LeftTear)
    					{
    						cha.Body.LeftTear.Yv = m.Value;
    					}
    					if (RightTear)
    					{
    						cha.Body.RightTear.Yv = m.Value;
    					}
    				}
    				else
    				{
    					if (LeftTear)
    					{
    						cha.Body.LeftTear.Tear0流れ1CD.不透明度 = m.Value;
    					}
    					if (RightTear)
    					{
    						cha.Body.RightTear.Tear0流れ1CD.不透明度 = m.Value;
    					}
    				}
    			},
    			OnReach = delegate
    			{
    				IsTearFlow = false;
    				if (LeftTear)
    				{
    					cha.Body.LeftTear.Yv = 1.0;
    				}
    				if (RightTear)
    				{
    					cha.Body.RightTear.Yv = 1.0;
    				}
    			},
    			OnLoop = delegate(Motion m)
    			{
    				m.End();
    			},
    			OnEnd = delegate
    			{
    			}
    		};
    		Motions.Add(TearFlow.GetHashCode().ToString(), TearFlow);
    		double vi;
    		TearFade = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 1.0,
    			OnStart = delegate
    			{
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				vi = m.Value.Inverse();
    				if (LeftTear)
    				{
    					cha.Body.LeftTear.Intensity *= vi;
    					if (cha.Body.IsDualEyes)
    					{
    						cha.Body.目左.黒目_ハイライト下CD.不透明度 *= vi;
    					}
    					if (cha.Body.IsCheekEyes)
    					{
    						cha.Body.頬目左.黒目_ハイライト下CD.不透明度 *= vi;
    					}
    					if (cha.Body.IsSingleEye)
    					{
    						cha.Body.単眼目.黒目_ハイライト下CD.不透明度 *= vi;
    					}
    					if (cha.Body.IsForeheadEye)
    					{
    						cha.Body.額目.黒目_ハイライト下CD.不透明度 *= vi;
    					}
    				}
    				if (RightTear)
    				{
    					cha.Body.RightTear.Intensity *= vi;
    					if (cha.Body.IsDualEyes)
    					{
    						cha.Body.目右.黒目_ハイライト下CD.不透明度 *= vi;
    					}
    					if (cha.Body.IsCheekEyes)
    					{
    						cha.Body.頬目右.黒目_ハイライト下CD.不透明度 *= vi;
    					}
    				}
    			},
    			OnReach = delegate(Motion m)
    			{
    				m.End();
    				m.ResetValue();
    				if (LeftTear)
    				{
    					cha.Body.LeftTear.表示 = false;
    					cha.Body.LeftTear.Intensity = 1.0;
    					if (cha.Body.IsDualEyes)
    					{
    						cha.Body.目左.黒目_ハイライト下_表示 = false;
    						cha.Body.目左.黒目_ハイライト下CD.不透明度 = 1.0;
    					}
    					if (cha.Body.IsCheekEyes)
    					{
    						cha.Body.頬目左.黒目_ハイライト下_表示 = false;
    						cha.Body.頬目左.黒目_ハイライト下CD.不透明度 = 1.0;
    					}
    					if (cha.Body.IsSingleEye)
    					{
    						cha.Body.単眼目.黒目_ハイライト下_表示 = false;
    						cha.Body.単眼目.黒目_ハイライト下CD.不透明度 = 1.0;
    					}
    					if (cha.Body.IsForeheadEye)
    					{
    						cha.Body.額目.黒目_ハイライト下_表示 = false;
    						cha.Body.額目.黒目_ハイライト下CD.不透明度 = 1.0;
    					}
    				}
    				if (RightTear)
    				{
    					cha.Body.RightTear.表示 = false;
    					cha.Body.RightTear.Intensity = 1.0;
    					if (cha.Body.IsDualEyes)
    					{
    						cha.Body.目右.黒目_ハイライト下_表示 = false;
    						cha.Body.目右.黒目_ハイライト下CD.不透明度 = 1.0;
    					}
    					if (cha.Body.IsCheekEyes)
    					{
    						cha.Body.頬目右.黒目_ハイライト下_表示 = false;
    						cha.Body.頬目右.黒目_ハイライト下CD.不透明度 = 1.0;
    					}
    				}
    			},
    			OnLoop = delegate
    			{
    			},
    			OnEnd = delegate
    			{
    			}
    		};
    		Motions.Add(TearFade.GetHashCode().ToString(), TearFade);
    		if (Body.IsDualEyes || Body.IsSingleEye)
    		{
    			BlinkMain = new Motion(0.0, 1.0)
    			{
    				BaseSpeed = 10.0,
    				GotoSpeed = 8.0,
    				RetuSpeed = 0.5,
    				LowestIncrease = 1.0,
    				Interval = 1000.0,
    				OnStart = delegate
    				{
    				},
    				OnUpdate = delegate(Motion m)
    				{
    					if (cha.Body.IsDualEyes)
    					{
    						cha.Body.瞼左v = m.Value.Clamp(cha.Body.Is瞼宇 ? 0.0 : cha.瞼基準左, 1.0);
    						cha.Body.瞼右v = m.Value.Clamp(cha.Body.Is瞼宇 ? 0.0 : cha.瞼基準右, 1.0);
    					}
    					if (cha.Body.IsSingleEye)
    					{
    						cha.Body.単眼瞼.Yv = m.Value.Clamp(cha.Body.Is瞼宇 ? 0.0 : cha.瞼基準単, 1.0);
    					}
    				},
    				OnReach = delegate
    				{
    					if (cha.泣き_)
    					{
    						cha.TearFlow.Start();
    					}
    				},
    				OnLoop = delegate(Motion m)
    				{
    					m.Interval = 5000.0 * Rng.XS.NextDouble();
    				},
    				OnEnd = delegate
    				{
    				}
    			};
    			Motions.Add(BlinkMain.GetHashCode().ToString(), BlinkMain);
    			BlinkMain.Start();
    		}
    		if (Body.IsCheekEyes || Body.IsForeheadEye)
    		{
    			BlinkExtra = new Motion(0.0, 1.0)
    			{
    				BaseSpeed = 10.0,
    				GotoSpeed = 8.0,
    				RetuSpeed = 0.5,
    				LowestIncrease = 1.0,
    				Interval = 1000.0,
    				OnStart = delegate
    				{
    				},
    				OnUpdate = delegate(Motion m)
    				{
    					if (cha.Body.IsCheekEyes)
    					{
    						cha.Body.頬瞼左.Yv = m.Value.Clamp(cha.瞼基準頬左, 1.0);
    						cha.Body.頬瞼右.Yv = m.Value.Clamp(cha.瞼基準頬右, 1.0);
    					}
    					if (cha.Body.IsForeheadEye)
    					{
    						cha.Body.額瞼.Yv = m.Value.Clamp(cha.瞼基準額, 1.0);
    					}
    				},
    				OnReach = delegate
    				{
    				},
    				OnLoop = delegate(Motion m)
    				{
    					m.Interval = 5000.0 * Rng.XS.NextDouble();
    				},
    				OnEnd = delegate
    				{
    				}
    			};
    			Motions.Add(BlinkExtra.GetHashCode().ToString(), BlinkExtra);
    			BlinkExtra.Start();
    		}
    		bool o = false;
    		double mouthCumIntensity = 0.0;
    		MouthCumDrip = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 0.8,
    			OnStart = delegate
    			{
    				cha.Body.MouthCum.Yi = 0;
    				mouthCumIntensity = cha.InternalCumLevel;
    				cha.Body.MouthCum.Intensity = 1.0 * mouthCumIntensity;
    				cha.Body.MouthCum.精液_表示 = true;
    				o = true;
    				cha.Body.MouthCum.右 = Rng.XS.NextBool();
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				if (o)
    				{
    					cha.Body.MouthCum.Yv = m.Value;
    				}
    				else
    				{
    					cha.Body.MouthCum.Intensity = m.Value * mouthCumIntensity;
    				}
    			},
    			OnReach = delegate
    			{
    				o = false;
    			},
    			OnLoop = delegate(Motion m)
    			{
    				cha.Body.MouthCum.表示 = false;
    				m.End();
    			},
    			OnEnd = delegate
    			{
    			}
    		};
    		Motions.Add(MouthCumDrip.GetHashCode().ToString(), MouthCumDrip);
    		bool v = false;
    		double genetalCumIntensity = 0.0;
    		double zd = Body.VaginalCumDrip.精液濃度;
    		GenitalCumDrip = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 0.8,
    			OnStart = delegate
    			{
    				cha.Body.GenetalCum.Yi = 0;
    				genetalCumIntensity = cha.InternalCumLevel;
    				cha.Body.GenetalCum.Intensity = 1.0 * genetalCumIntensity;
    				cha.Body.GenetalCum.精液_表示 = true;
    				v = true;
    				zd = cha.Body.VaginalCumDrip.精液濃度;
    				cha.Body.GenetalCum.右 = Rng.XS.NextBool();
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				if (v)
    				{
    					cha.Body.GenetalCum.Yv = m.Value;
    					cha.Body.VaginalCumDrip.精液濃度 = zd * m.Value.Inverse();
    				}
    				else
    				{
    					cha.Body.GenetalCum.Intensity = m.Value * genetalCumIntensity;
    				}
    			},
    			OnReach = delegate
    			{
    				v = false;
    			},
    			OnLoop = delegate(Motion m)
    			{
    				cha.Body.GenetalCum.表示 = false;
    				m.End();
    			},
    			OnEnd = delegate
    			{
    			}
    		};
    		Motions.Add(GenitalCumDrip.GetHashCode().ToString(), GenitalCumDrip);
    		bool a = false;
    		double analCumIntensity = 0.0;
    		AnalCumDrip = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 0.8,
    			OnStart = delegate
    			{
    				cha.Body.AnalCum.Yi = 0;
    				analCumIntensity = cha.InternalCumLevel;
    				cha.Body.AnalCum.Intensity = 1.0 * analCumIntensity;
    				cha.Body.AnalCum.精液_表示 = true;
    				a = true;
    				cha.Body.AnalCum.右 = Rng.XS.NextBool();
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				if (a)
    				{
    					cha.Body.AnalCum.Yv = m.Value;
    				}
    				else
    				{
    					cha.Body.AnalCum.Intensity = m.Value * analCumIntensity;
    				}
    			},
    			OnReach = delegate
    			{
    				a = false;
    			},
    			OnLoop = delegate(Motion m)
    			{
    				cha.Body.AnalCum.表示 = false;
    				m.End();
    			},
    			OnEnd = delegate
    			{
    			}
    		};
    		Motions.Add(AnalCumDrip.GetHashCode().ToString(), AnalCumDrip);
    		bool z = false;
    		double threadCumIntensity = 0.0;
    		ThreadCumDrip = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 0.8,
    			OnStart = delegate
    			{
    				cha.Body.ThreadCum.Yi = 0;
    				threadCumIntensity = cha.InternalCumLevel;
    				cha.Body.ThreadCum.Intensity = 1.0 * threadCumIntensity;
    				cha.Body.ThreadCum.精液_表示 = true;
    				z = true;
    				cha.Body.ThreadCum.右 = Rng.XS.NextBool();
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				if (z)
    				{
    					cha.Body.ThreadCum.Yv = m.Value;
    				}
    				else
    				{
    					cha.Body.ThreadCum.Intensity = m.Value * threadCumIntensity;
    				}
    			},
    			OnReach = delegate
    			{
    				z = false;
    			},
    			OnLoop = delegate(Motion m)
    			{
    				cha.Body.ThreadCum.表示 = false;
    				m.End();
    			},
    			OnEnd = delegate
    			{
    			}
    		};
    		Motions.Add(ThreadCumDrip.GetHashCode().ToString(), ThreadCumDrip);
    		SquirtSmall = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 4.0,
    			OnStart = delegate
    			{
    				cha.Body.潮吹_小.Yv = 0.0;
    				cha.Body.潮吹_小.表示 = true;
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				cha.Body.潮吹_小.Yv = m.Value;
    			},
    			OnReach = delegate(Motion m)
    			{
    				m.End();
    			},
    			OnLoop = delegate
    			{
    			},
    			OnEnd = delegate
    			{
    				cha.Body.潮吹_小.表示 = false;
    				cha.Body.SplashIntencity = (cha.Body.SplashIntencity + 0.01).Clamp(0.0, 1.0);
    			}
    		};
    		Motions.Add(SquirtSmall.GetHashCode().ToString(), SquirtSmall);
    		SquirtLarge = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 4.0,
    			OnStart = delegate
    			{
    				cha.Body.潮吹_大.Yv = 0.0;
    				cha.Body.潮吹_大.表示 = true;
    				cha.Body.潮吹_大.右 = Rng.XS.NextBool();
    				if (cha.潮吹擬音 != null)
    				{
    					cha.潮吹擬音();
    				}
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				cha.Body.潮吹_大.Yv = m.Value;
    			},
    			OnReach = delegate(Motion m)
    			{
    				m.End();
    			},
    			OnLoop = delegate
    			{
    			},
    			OnEnd = delegate
    			{
    				cha.Body.潮吹_大.表示 = false;
    				cha.Body.SquirtStainIntensity = (cha.Body.SquirtStainIntensity + 0.2).Clamp(0.0, 1.0);
    			}
    		};
    		Motions.Add(SquirtLarge.GetHashCode().ToString(), SquirtLarge);
    		Motion Stain = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 0.1,
    			OnStart = delegate
    			{
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				cha.Body.UrineStainIntensity = m.Value;
    			},
    			OnReach = delegate(Motion m)
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
    		Motions.Add(Stain.GetHashCode().ToString(), Stain);
    		Motion UrinationStage1 = null;
    		Motion UrinationStage2 = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 1.0,
    			OnStart = delegate
    			{
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				cha.Body.Urination.Intensity = m.Value.Inverse();
    				ChaD.Shyness = (ChaD.Shyness + 0.002).Clamp(0.0, 1.0);
    			},
    			OnReach = delegate(Motion m)
    			{
    				m.End();
    			},
    			OnLoop = delegate
    			{
    			},
    			OnEnd = delegate
    			{
    				cha.Body.Urination.表示 = false;
    				cha.Body.Urination.Intensity = 1.0;
    				UrinationStage1.End();
    			}
    		};
    		Motions.Add(UrinationStage2.GetHashCode().ToString(), UrinationStage2);
    		Stopwatch sw = new Stopwatch();
    		UrinationStage1 = new Motion(8.0, 10.0)
    		{
    			BaseSpeed = 10.0,
    			OnStart = delegate
    			{
    				cha.Body.Urination.Yi = 8;
    				sw.Start();
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				if (sw.ElapsedMilliseconds > 4000)
    				{
    					UrinationStage2.Start();
    				}
    				else if (cha.放尿擬音 != null)
    				{
    					cha.放尿擬音();
    				}
    				cha.Body.Urination.Yi = (int)m.Value;
    				ChaD.Shyness = (ChaD.Shyness + 0.002).Clamp(0.0, 1.0);
    			},
    			OnReach = delegate
    			{
    			},
    			OnLoop = delegate
    			{
    			},
    			OnEnd = delegate
    			{
    				sw.Reset();
    			}
    		};
    		Motions.Add(UrinationStage1.GetHashCode().ToString(), UrinationStage1);
    		Motion Steam = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 0.2,
    			OnStart = delegate
    			{
    				cha.Body.湯気左濃度 = 0.0;
    				cha.Body.湯気右濃度 = 0.0;
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				cha.Body.湯気左濃度 = m.Value;
    				cha.Body.湯気右濃度 = m.Value;
    			},
    			OnReach = delegate
    			{
    			},
    			OnLoop = delegate(Motion m)
    			{
    				m.End();
    			},
    			OnEnd = delegate
    			{
    			}
    		};
    		Motions.Add(Steam.GetHashCode().ToString(), Steam);
    		Urination = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 0.6,
    			OnStart = delegate
    			{
    				cha.Body.Urination.Yv = 0.0;
    				cha.Body.Urination.表示 = true;
    				if (cha.Body.UrineStainIntensity != 1.0)
    				{
    					Stain.Start();
    				}
    				//Sounds.放尿.Play();
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				cha.Body.Urination.Yv = m.Value;
    				if (cha.放尿擬音 != null)
    				{
    					cha.放尿擬音();
    				}
    				ChaD.Shyness = (ChaD.Shyness + 0.002).Clamp(0.0, 1.0);
    			},
    			OnReach = delegate(Motion m)
    			{
    				m.End();
    			},
    			OnLoop = delegate
    			{
    			},
    			OnEnd = delegate
    			{
    				UrinationStage1.Start();
    				Steam.Start();
    			}
    		};
    		Motions.Add(Urination.GetHashCode().ToString(), Urination);
    		放尿強制終了_ = delegate
    		{
    			cha.Urination.End();
    			UrinationStage1.End();
    			Steam.End();
    			UrinationStage2.End();
    			Stain.End();
    		};
    		IsUrinating = () => cha.Urination.Run || UrinationStage1.Run || UrinationStage2.Run;
    		MilkSpray = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 2.0,
    			OnStart = delegate
    			{
    				cha.Body.LeftMilkSpray.Yi = 0;
    				cha.Body.RightMilkSpary.Yi = 0;
    				cha.Body.LeftMilkSpray.母乳1_表示 = true;
    				cha.Body.LeftMilkSpray.母乳2_表示 = true;
    				cha.Body.LeftMilkSpray.母乳3_表示 = true;
    				cha.Body.LeftMilkSpray.母乳4_表示 = true;
    				cha.Body.RightMilkSpary.母乳1_表示 = true;
    				cha.Body.RightMilkSpary.母乳2_表示 = true;
    				cha.Body.RightMilkSpary.母乳3_表示 = true;
    				cha.Body.RightMilkSpary.母乳4_表示 = true;
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				cha.Body.LeftMilkSpray.Yv = m.Value;
    				cha.Body.RightMilkSpary.Yv = m.Value;
    			},
    			OnReach = delegate(Motion m)
    			{
    				m.End();
    			},
    			OnLoop = delegate
    			{
    			},
    			OnEnd = delegate
    			{
    				cha.Body.LeftMilkSpray.母乳1_表示 = false;
    				cha.Body.LeftMilkSpray.母乳2_表示 = false;
    				cha.Body.LeftMilkSpray.母乳3_表示 = false;
    				cha.Body.LeftMilkSpray.母乳4_表示 = false;
    				cha.Body.LeftMilkSpray.母乳垂れ1_表示 = true;
    				cha.Body.LeftMilkSpray.母乳垂れ2_表示 = true;
    				cha.Body.RightMilkSpary.母乳1_表示 = false;
    				cha.Body.RightMilkSpary.母乳2_表示 = false;
    				cha.Body.RightMilkSpary.母乳3_表示 = false;
    				cha.Body.RightMilkSpary.母乳4_表示 = false;
    				cha.Body.RightMilkSpary.母乳垂れ1_表示 = true;
    				cha.Body.RightMilkSpary.母乳垂れ2_表示 = true;
    				cha.MilkStain = (cha.MilkStain + 0.03).Clamp(0.0, 1.0);
    			}
    		};
    		Motions.Add(MilkSpray.GetHashCode().ToString(), MilkSpray);
    		int s;
    		Vector2D ev;
    		EyeTracking = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 0.1,
    			OnStart = delegate
    			{
    			},
    			OnUpdate = delegate
    			{
    				s = ((!cha.LookAway) ? 1 : (-1));
    				if (cha.LookAway)
    				{
    					if (cha.Body.IsDualEyes)
    					{
    						ev = s * (cha.CursorPosition - (cha.Body.目左.位置 + cha.Body.目右.位置) * 0.5).newNormalize() * 0.002;
    						cha.Body.目左.視線 = ev;
    						cha.Body.目右.視線 = ev;
    					}
    					if (cha.Body.IsCheekEyes)
    					{
    						ev = s * (cha.CursorPosition - (cha.Body.頬目左.位置 + cha.Body.頬目右.位置) * 0.5).newNormalize() * 0.00089;
    						cha.Body.頬目左.視線 = ev;
    						cha.Body.頬目右.視線 = ev;
    					}
    					if (cha.Body.IsForeheadEye)
    					{
    						ev = s * (cha.CursorPosition - cha.Body.額目.位置).newNormalize() * 0.00089;
    						cha.Body.額目.視線 = ev;
    					}
    					if (cha.Body.IsSingleEye)
    					{
    						ev = s * (cha.CursorPosition - cha.Body.単眼目.位置).newNormalize() * 0.003;
    						cha.Body.単眼目.視線 = ev;
    					}
    				}
    				else
    				{
    					if (cha.Body.IsDualEyes)
    					{
    						cha.Body.目左.視線 = s * (cha.CursorPosition - cha.Body.目左.位置).newNormalize() * 0.002;
    						cha.Body.目右.視線 = s * (cha.CursorPosition - cha.Body.目右.位置).newNormalize() * 0.002;
    					}
    					if (cha.Body.IsCheekEyes)
    					{
    						cha.Body.頬目左.視線 = s * (cha.CursorPosition - cha.Body.頬目左.位置).newNormalize() * 0.00089;
    						cha.Body.頬目右.視線 = s * (cha.CursorPosition - cha.Body.頬目右.位置).newNormalize() * 0.00089;
    					}
    					if (cha.Body.IsForeheadEye)
    					{
    						cha.Body.額目.視線 = s * (cha.CursorPosition - cha.Body.額目.位置).newNormalize() * 0.00089;
    					}
    					if (cha.Body.IsSingleEye)
    					{
    						cha.Body.単眼目.視線 = s * (cha.CursorPosition - cha.Body.単眼目.位置).newNormalize() * 0.003;
    					}
    				}
    			},
    			OnReach = delegate
    			{
    			},
    			OnLoop = delegate
    			{
    			},
    			OnEnd = delegate
    			{
    			}
    		};
    		Motions.Add(EyeTracking.GetHashCode().ToString(), EyeTracking);
    		double l = 1.0;
    		ClimaxEnd = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 0.2 - 0.15 * ClimaxDuration,
    			OnStart = delegate(Motion m)
    			{
    				m.BaseSpeed = 0.2 - 0.15 * cha.ClimaxDuration;
    				l = 1.0;
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				l = m.Value.Inverse();
    			},
    			OnReach = delegate(Motion m)
    			{
    				m.End();
    			},
    			OnLoop = delegate
    			{
    			},
    			OnEnd = delegate
    			{
    				cha.Climax.End();
    				Player.絶頂終了処理();
    			}
    		};
    		Motions.Add(ClimaxEnd.GetHashCode().ToString(), ClimaxEnd);
    		double savedHipValue = 0.0;
    		ShapePart pa = Body.Waist.Body.GetCurJoinRoot();
    		ShapePart pb = null;
    		Vector2D vec = DataConsts.Vec2DZero;
    		Action 腰接続 = delegate
    		{
    			pb = cha.Body.Waist.Body.GetCurJoinRoot();
    			vec = pb.ToGlobal(pb.GetJP()[5].Joint) - pa.ToGlobal(pa.GetJP()[5].Joint);

                ApplyContParts(vec);
    		};
    		double d;
    		Climax = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 20.0,
    			OnStart = delegate
    			{
    				savedHipValue = cha.Body.Waist.Yv;
    				cha.ClimaxEnd.Start();
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				d = 5.0 * (0.15 + cha.ClimaxIntensity) * m.Value.Sin() * Rng.XS.NextDouble() * l;

                    cha.ApplyMorphMotions(d, false);
    				
    				cha.Body.HipMotionValue = d * Rng.XS.NextDouble();
    				cha.Body.Waist.位置C = new Vector2D(0.0, 0.0005 * d);
    				cha.Body.乳房左.位置C = cha.Body.Waist.位置C;
    				cha.Body.乳房右.位置C = cha.Body.Waist.位置C;
    				if (cha.Body.Is腕前)
    				{
    					cha.Body.EI腕前.Updatef = true;
    				}
    				腰接続();
    				Player.絶頂中処理();
    				if (0.3.Lot())
    				{
    					Player.奴体力消費中();
    				}
    			},
    			OnReach = delegate
    			{
    			},
    			OnLoop = delegate
    			{
    			},
    			OnEnd = delegate
    			{
    				cha.Body.HipMotion_人v = savedHipValue;
    				cha.Body.Waist.位置C = DataConsts.Vec2DZero;
    				if (!cha.Body.乳房左.着衣)
    				{
    					cha.Body.乳房左.位置C = DataConsts.Vec2DZero;
    					cha.Body.乳房右.位置C = DataConsts.Vec2DZero;
    				}

                    ResetContParts();
    			}
    		};
    		Motions.Add(Climax.GetHashCode().ToString(), Climax);
    		Stopwatch 肛sw = new Stopwatch();
    		肛ヒク = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 1.0,
    			OnStart = delegate
    			{
    				肛sw.Restart();
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				cha.Body.肛門C = 0.5 + m.Value.Sin() * Rng.XS.NextDouble() * 0.5;
    				if (肛sw.ElapsedMilliseconds > 5000)
    				{
    					m.End();
    				}
    			},
    			OnReach = delegate
    			{
    			},
    			OnLoop = delegate
    			{
    			},
    			OnEnd = delegate
    			{
    				肛sw.Stop();
    				cha.Body.肛門C = 1.0;
    			}
    		};
    		Motions.Add(肛ヒク.GetHashCode().ToString(), 肛ヒク);
    		Stopwatch 膣sw = new Stopwatch();
    		膣ヒク = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 1.0,
    			OnStart = delegate
    			{
    				膣sw.Restart();
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				cha.Body.膣腔C = 1.0 + m.Value.Sin() * Rng.XS.NextDouble() * 0.5;
    				if (膣sw.ElapsedMilliseconds > 5000)
    				{
    					m.End();
    				}
    			},
    			OnReach = delegate
    			{
    			},
    			OnLoop = delegate
    			{
    			},
    			OnEnd = delegate
    			{
    				膣sw.Stop();
    				cha.Body.膣腔C = 1.0;
    			}
    		};
    		Motions.Add(膣ヒク.GetHashCode().ToString(), 膣ヒク);
    		Stopwatch 糸sw = new Stopwatch();
    		糸ヒク = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 0.1,
    			OnStart = delegate
    			{
    				糸sw.Restart();
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				if (cha.Body.Is蜘尾)
    				{
    					cha.Body.出糸C = m.Value.Sin() * 30.0;
    				}
    				if (糸sw.ElapsedMilliseconds > 5000)
    				{
    					m.End();
    				}
    			},
    			OnReach = delegate
    			{
    			},
    			OnLoop = delegate
    			{
    			},
    			OnEnd = delegate
    			{
    				糸sw.Stop();
    				if (cha.Body.Is蜘尾)
    				{
    					cha.Body.出糸C = 0.0;
    				}
    			}
    		};
    		Motions.Add(糸ヒク.GetHashCode().ToString(), 糸ヒク);
    		bool 顔面開き = false;
    		bool Is展開 = Body.Is顔面 || Body.Is大顎基;
    		顔面 顔面 = Body.顔面;
    		大顎基 大顎 = Body.頭.大顎基_接続.GetEle<大顎基>();
    		角1_虫 虫角 = Body.頭.額_接続.GetEle<角1_虫>();
    		double o_ = 0.0;
    		顔面展開 = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 5.0,
    			OnStart = delegate
    			{
    				if (Is展開)
    				{
    					顔面開き = o_ == 1.0;
    				}
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				if (Is展開)
    				{
    					if (顔面開き)
    					{
    						o_ = m.Value.Inverse();
    					}
    					else
    					{
    						o_ = m.Value;
    					}
    					if (cha.Body.Is顔面)
    					{
    						顔面.展開0 = o_;
    						顔面.展開1 = o_;
    					}
    					if (cha.Body.Is大顎基)
    					{
    						大顎.展開 = o_;
    					}
    					if (cha.Body.Is虫角)
    					{
    						虫角.展開 = o_;
    					}
    				}
    			},
    			OnReach = delegate(Motion m)
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
    		Motions.Add(顔面展開.GetHashCode().ToString(), 顔面展開);
    		Vector2D p_ = DataConsts.Vec2DZero;
    		double d_;
    		BodySway = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 7.0,
    			OnStart = delegate
    			{
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				d_ = 2.0 * m.Value;

                    ApplyMorphMotions(d_, true);

    				p_.Y = -0.001 * m.Value;
    				cha.Body.Waist.位置C = p_;
    				cha.Body.乳房左.位置C = cha.Body.Waist.位置C;
    				cha.Body.乳房右.位置C = cha.Body.Waist.位置C;

                    ApplyMoveParts(p_);
    			},
    			OnReach = delegate
    			{
    			},
    			OnLoop = delegate(Motion m)
    			{
    				m.End();
    			},
    			OnEnd = delegate
    			{
    				cha.Body.Waist.位置C = DataConsts.Vec2DZero;
    				if (!cha.Body.乳房左.着衣)
    				{
    					cha.Body.乳房左.位置C = DataConsts.Vec2DZero;
    					cha.Body.乳房右.位置C = DataConsts.Vec2DZero;
    				}

                    ResetMoveParts();
    			}
    		};
    		Motions.Add(BodySway.GetHashCode().ToString(), BodySway);
    		int c_ = 0;
    		int CoughCount = 1;
    		Cough = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 10.0,
    			GotoSpeed = 0.5,
    			RetuSpeed = 2.0,
    			OnStart = delegate
    			{
    				cha.UpdateExpression();
    				if (cha.Body.IsDualEyes)
    				{
    					cha.両瞼_1(Rng.XS.Next(1, 4), Rng.XS.Next(1, 4));
    				}
    				else if (cha.Body.IsSingleEye)
    				{
    					cha.単瞼_1(Rng.XS.Next(1, 4));
    				}
    				if (cha.Body.IsCheekEyes)
    				{
    					cha.両頬瞼_1(Rng.XS.Next(1, 4), Rng.XS.Next(1, 4));
    				}
    				if (cha.Body.IsForeheadEye)
    				{
    					cha.額瞼_1(Rng.XS.Next(1, 4));
    				}
    				c_ = 0;
    				CoughCount = Rng.XS.NextM(1, 2) + Player.UI.ペニス処理.中出しCount / 2;
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				cha.BreathingValue = m.Value;
    			},
    			OnReach = delegate
    			{
    				cha.SpitSplash.Start();
    				if ((Player.UI.ペニス処理.中出し || cha.Crying) && 0.18.Lot())
    				{
    					cha.NoseDrip.Start();
    				}
    				if (Player.UI.ペニス処理.中出し && 0.25.Lot())
    				{
    					cha.Drool.Start();
    				}
    			},
    			OnLoop = delegate(Motion m)
    			{
    				c_++;
    				if (c_ >= CoughCount)
    				{
    					m.End();
    				}
    			},
    			OnEnd = delegate
    			{
    				cha.SetInitialExpression();
    				cha.口();
    			}
    		};
    		Motions.Add(Cough.GetHashCode().ToString(), Cough);
    		double 中出度_ = 0.0;
    		Swallow = new Motion(0.0, 1.0)
    		{
    			BaseSpeed = 1.0,
    			OnStart = delegate
    			{
    				cha.UpdateExpression();
    				cha.口_紡ぎ();
    				中出度_ = cha.InternalCumLevel;
    			},
    			OnUpdate = delegate(Motion m)
    			{
    				cha.BreathingValue = m.Value;
    			},
    			OnReach = delegate
    			{
    			},
    			OnLoop = delegate(Motion m)
    			{
    				m.End();
    			},
    			OnEnd = delegate
    			{
    				if (Rng.XS.NextBool())
    				{
    					//Sounds.挿抜口1.Play();
    				}
    				else
    				{
    					//Sounds.挿抜口2.Play();
    				}
    				ChaD.Stamina = (ChaD.Stamina + 0.3 * 中出度_).Clamp(0.0, 1.0);
    			}
    		};
    		Motions.Add(Swallow.GetHashCode().ToString(), Swallow);
    		Motions.Drive(Med.FPSF);
    		Med.SetUniqueColor(Body.Elements.Select((Element e) => e.Body.EnumAllPar()).JoinEnum());
    		汗掻き = new Sweat(Med, Are, this, Motions);
    		汗かき = 汗掻き.汗かき;
    		Body.汗掻き = 汗掻き;
    		this.SetInitialAngle();
    	}

    	public void Draw(RenderArea Are, FpsCounter FPS)
    	{
    		this.FPS = FPS.Value;
    		Motions.Drive(FPS);
    		Body.描画(Are);
    	}

    	public void Dispose()
    	{
    		Body.Dispose();
    		汗掻き.Dispose();
    		ModeEventDispatcher.RemUniqueColor(Body.Elements.Select((Element e) => e.Body.EnumAllPar()).JoinEnum());
    	}

    	public void Set衣装(IEnumerable<object> 衣装)
    	{
    		Body.脱衣();
    		Dictionary<Type, int> dictionary = new Dictionary<Type, int>();
    		Dictionary<Type, PropertyInfo[]> dictionary2 = new Dictionary<Type, PropertyInfo[]>();
    		string ts;
    		foreach (object item in 衣装)
    		{
    			Type type = item.GetType();
    			ts = type.ToString();
    			if (dictionary.ContainsKey(type))
    			{
    				dictionary2[type][dictionary[type]].SetValue(Body, item, null);
    				dictionary[type]++;
    				continue;
    			}
    			dictionary.Add(type, 0);
    			dictionary2.Add(type, (from e in GlobalState.Bodt.GetProperties()
    				where e.PropertyType.ToString() == ts
    				select e).ToArray());
    			dictionary2[type][dictionary[type]].SetValue(Body, item, null);
    			dictionary[type]++;
    		}
    		if (!CharacterData.股施術 && Body.Is股防御())
    		{
    			Body.Setピアス = GlobalState.ピアス初期化;
    		}
    		if (!CharacterData.胸施術 && Body.Is胸甲殻())
    		{
    			Body.Setピアス左 = GlobalState.ピアス初期化;
    			Body.Setピアス右 = GlobalState.ピアス初期化;
    		}
    	}

        public ContactD GetContact(ref Color HitColor)
        {
            ContactD result = default(ContactD);
            result.e = this.Body.GetHitEle(HitColor);
            if (result.e != null)
            {
                result.p = result.e.Body.GetHitPar_(HitColor);
                bool flag = false;
                bool flag2 = result.e is Shoulder || result.e is UpperArm || result.e is LowerArm || result.e is 手 || result.e is 四足脇 || result.e is 腿 || result.e is Leg || result.e is 足 || result.e is 鰭 || result.e is 葉 || result.e is 前翅 || result.e is 後翅 || result.e is 触肢 || result.e is 節足 || result.e is 節尾 || result.e is 大顎 || result.e is 虫顎 || result.e is 虫鎌 || result.e is 触手;
                if (result.e is 前髪 || result.e is 頭頂)
                {
                    result.c = ContactType.Head;
                }
                else if (result.e is 耳 || result.e is 獣耳)
                {
                    result.c = ContactType.Ear;
                }
                else if (this.Body.Is口腔())
                {
                    result.c = ContactType.Mouth;
                }
                else if (result.e is Head)
                {
                    result.c = ContactType.Face;
                }
                else if (result.e is SideHair || result.e is BackHair0 || result.e is BackHair1 || result.e is 基髪)
                {
                    result.c = ContactType.Hair;
                }
                else if (result.e is Neck)
                {
                    result.c = ContactType.Neck;
                }
                else if (result.e is Shoulder)
                {
                    result.c = ContactType.Shoulder;
                }
                else if (!flag2 && !this.Body.乳房左.虫性_甲殻_表示 && !(result.p.Tag == "乳房") && this.Body.Is乳首())
                {
                    result.c = ContactType.Milk;
                }
                else if (result.e is 乳房)
                {
                    result.c = ContactType.Chest;
                }
                else if (result.e is Chest)
                {
                    result.c = ContactType.Side;
                }
                else if (((result.e is Waist || result.e is 四足腰) && result.p != null && result.p.Tag == "下腹") || result.e is ボテ腹)
                {
                    result.c = ContactType.Stomache;
                }
                else if ((flag = !flag2 && this.Body.Isくぱぁ()) && result.e is 肛門)
                {
                    result.c = ContactType.Anal;
                }
                else if (flag && this.Body.Is陰核())
                {
                    result.c = ContactType.Nucleus;
                }
                else if (flag && this.Body.Is膣口())
                {
                    result.c = ContactType.Vagina;
                }
                else if (flag && result.e is 性器)
                {
                    result.c = ContactType.Sex;
                }
                else if (flag && this.Body.Is局部())
                {
                    result.c = ContactType.Crotch;
                }
                else if (result.e is 尾_蜘 && (result.p.Tag.Contains("出糸突起左") || result.p.Tag.Contains("出糸突起中") || result.p.Tag.Contains("出糸突起右")))
                {
                    result.c = ContactType.Thread;
                }
                else if (result.e.ConnectionType.ToString().Contains("腿") && !result.e.ConnectionType.Is左右無し())
                {
                    result.c = ContactType.Thigh;
                }
                else if (result.e is 足_人)
                {
                    result.c = ContactType.Feet;
                }
                else if (result.e is 手_人)
                {
                    result.c = ContactType.Hand;
                }
                else if (result.e is 触覚)
                {
                    result.c = ContactType.Awareness;
                }
                else if (result.e is 触手)
                {
                    result.c = ContactType.Touch;
                }
                else if (result.e.ConnectionType.ToString().Contains("尾"))
                {
                    result.c = ContactType.Tail;
                }
                else if (result.e is 前翅 || result.e is 後翅 || result.e is UpperArm_鳥 || result.e is LowerArm_鳥 || result.e is 手_鳥 || result.e is UpperArm_蝙 || result.e is LowerArm_蝙 || result.e is 手_蝙)
                {
                    result.c = ContactType.Wing;
                }
                else if (result.e is 鰭)
                {
                    result.c = ContactType.Fin;
                }
                else
                {
                    result.c = ContactType.Other;
                }
            }
            return result;
        }
    }
}
