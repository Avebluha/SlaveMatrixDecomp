using System;
using System.Globalization;

namespace _2DGAMELIB
{
    [Serializable]
    public struct MatrixD
    {
    	public double M11;

    	public double M12;

    	public double M13;

    	public double M14;

    	public double M21;

    	public double M22;

    	public double M23;

    	public double M24;

    	public double M31;

    	public double M32;

    	public double M33;

    	public double M34;

    	public double M41;

    	public double M42;

    	public double M43;

    	public double M44;

    	public double this[int row, int col]
    	{
    		get
    		{
    			switch (row)
    			{
    			case 0:
    				switch (col)
    				{
    				case 0:
    					return M11;
    				case 1:
    					return M12;
    				case 2:
    					return M13;
    				case 3:
    					return M14;
    				default:
    					error(row, col);
    					return 0.0;
    				}
    			case 1:
    				switch (col)
    				{
    				case 0:
    					return M21;
    				case 1:
    					return M22;
    				case 2:
    					return M23;
    				case 3:
    					return M24;
    				default:
    					error(row, col);
    					return 0.0;
    				}
    			case 2:
    				switch (col)
    				{
    				case 0:
    					return M31;
    				case 1:
    					return M32;
    				case 2:
    					return M33;
    				case 3:
    					return M34;
    				default:
    					error(row, col);
    					return 0.0;
    				}
    			case 3:
    				switch (col)
    				{
    				case 0:
    					return M41;
    				case 1:
    					return M42;
    				case 2:
    					return M43;
    				case 3:
    					return M44;
    				default:
    					error(row, col);
    					return 0.0;
    				}
    			default:
    				error(row, col);
    				return 0.0;
    			}
    		}
    		set
    		{
    			switch (row)
    			{
    			case 0:
    				switch (col)
    				{
    				case 0:
    					M11 = value;
    					break;
    				case 1:
    					M12 = value;
    					break;
    				case 2:
    					M13 = value;
    					break;
    				case 3:
    					M14 = value;
    					break;
    				default:
    					error(row, col);
    					break;
    				}
    				break;
    			case 1:
    				switch (col)
    				{
    				case 0:
    					M21 = value;
    					break;
    				case 1:
    					M22 = value;
    					break;
    				case 2:
    					M23 = value;
    					break;
    				case 3:
    					M24 = value;
    					break;
    				default:
    					error(row, col);
    					break;
    				}
    				break;
    			case 2:
    				switch (col)
    				{
    				case 0:
    					M31 = value;
    					break;
    				case 1:
    					M32 = value;
    					break;
    				case 2:
    					M33 = value;
    					break;
    				case 3:
    					M34 = value;
    					break;
    				default:
    					error(row, col);
    					break;
    				}
    				break;
    			case 3:
    				switch (col)
    				{
    				case 0:
    					M41 = value;
    					break;
    				case 1:
    					M42 = value;
    					break;
    				case 2:
    					M43 = value;
    					break;
    				case 3:
    					M44 = value;
    					break;
    				default:
    					error(row, col);
    					break;
    				}
    				break;
    			default:
    				error(row, col);
    				break;
    			}
    		}
    	}

    	public MatrixD(double M11, double M12, double M13, double M14, double M21, double M22, double M23, double M24, double M31, double M32, double M33, double M34, double M41, double M42, double M43, double M44)
    	{
    		this.M11 = M11;
    		this.M12 = M12;
    		this.M13 = M13;
    		this.M14 = M14;
    		this.M21 = M21;
    		this.M22 = M22;
    		this.M23 = M23;
    		this.M24 = M24;
    		this.M31 = M31;
    		this.M32 = M32;
    		this.M33 = M33;
    		this.M34 = M34;
    		this.M41 = M41;
    		this.M42 = M42;
    		this.M43 = M43;
    		this.M44 = M44;
    	}

    	private void error(int row, int col)
    	{
    		if (row < 0 || row > 3)
    		{
    			throw new ArgumentOutOfRangeException("row", "Rows and columns for matrices run from 0 to 3, inclusive.");
    		}
    		if (col < 0 || col > 3)
    		{
    			throw new ArgumentOutOfRangeException("col", "Rows and columns for matrices run from 0 to 3, inclusive.");
    		}
    	}
    }
}
