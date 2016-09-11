using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gen3TIDSIDFrameFinder
{
	public partial class FrameFinder : Form
	{
		private DataTable outputTable;

		public FrameFinder()
		{
			InitializeComponent();

			gameComboBox.SelectedIndex = 0;

			outputTable = new DataTable();
			DataColumn[] columns = {
				new DataColumn("Frame", typeof(int)),
				new DataColumn("SID", typeof(ushort))
			};
			outputTable.Columns.AddRange(columns);
			outputGridView.DataSource = outputTable;
		}

		private void GetMultiplierAndAdder(out uint multiplier, out uint adder)
		{
			switch(gameComboBox.SelectedIndex)
			{
				case 0: // Emerald
				case 1: // FRLG
					multiplier = 0x41c64e6d;
					adder = 0x00006073;
					break;
				default: // Colosseum
					multiplier = 0x000343FD;
					adder = 0x00269EC3;
					break;
			}
		}

		private void OnFindFrameClick(object sender, EventArgs e)
		{
			outputTable.Clear();

			uint pid, prng, multiplier, adder;
			ushort tid;
			int currentFrame, maxFrame;

			uint.TryParse(pidTextBox.Text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out pid);
			uint.TryParse(prngTextBox.Text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out prng);
			ushort.TryParse(tidTextBox.Text, out tid);
			int.TryParse(minFrameTextBox.Text, out currentFrame);
			int.TryParse(maxFrameTextBox.Text, out maxFrame);

			GetMultiplierAndAdder(out multiplier, out adder);

			uint seed = prng;
			int frameOffset = currentFrame;

			// get first sid
			ushort nextsid = GetShortSeed(GetNextSeed(seed, multiplier, adder));

			for(int seedFrame = 0; seedFrame <= maxFrame; seedFrame++)
			{
				seed = GetNextSeed(seed, multiplier, adder);
				nextsid = GetShortSeed(seed);

				bool isShiny = IsShiny(pid, tid, nextsid);
				if(isShiny)
				{
					int emuFrame = seedFrame + frameOffset;
					DataRow row = outputTable.NewRow();
					row["Frame"] = emuFrame;
					row["SID"] = nextsid;
					outputTable.Rows.Add(row);
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			uint pid, prng, multiplier, adder;
			ushort tid, acquiredSid;
			int currentFrame, attemptedFrame, maxFrame;

			int.TryParse(minFrameTextBox.Text, out currentFrame);
			int.TryParse(maxFrameTextBox.Text, out maxFrame);
			int.TryParse(attemptedFrameTextBox.Text, out attemptedFrame);
			ushort.TryParse(acquiredSidTextBox.Text, out acquiredSid);
			uint.TryParse(pidTextBox.Text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out pid);
			uint.TryParse(prngTextBox.Text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out prng);
			ushort.TryParse(tidTextBox.Text, out tid);

			GetMultiplierAndAdder(out multiplier, out adder);

			List<string> lines = new List<string>();
			uint seed = prng;

			int acquiredFrame = GetSidFrame(seed, 0, maxFrame, acquiredSid) + currentFrame;
			int frameDifference = attemptedFrame - acquiredFrame;

			frameOffsetTextBox.Text = frameDifference.ToString();
			adjustedFrameTextBox.Text = (attemptedFrame + frameDifference).ToString();
			Console.WriteLine(
				"acquired frame: {0}, frame difference: {1}, adjusted frame: {2}",
				acquiredFrame,
				frameDifference,
				attemptedFrame + frameDifference
			);
		}

		private int GetSidFrame(uint seed, int seedFrame, int maxFrame, ushort sid)
		{
			uint multiplier, adder;
			GetMultiplierAndAdder(out multiplier, out adder);

			ushort nextsid = GetShortSeed(GetNextSeed(seed, multiplier, adder));

			for(; seedFrame <= maxFrame; seedFrame++)
			{
				seed = GetNextSeed(seed, multiplier, adder);
				nextsid = GetShortSeed(seed);

				if(nextsid == sid)
				{
					return seedFrame;
				}
			}

			return 0;
		}

		private ushort GetShortSeed(uint seed)
		{
			return (ushort)(seed >> 16);
		}

		private uint GetNextSeed(uint seed, uint multiplier, uint adder)
		{
			return seed * multiplier + adder;
		}

		private bool IsShiny(uint pid, ushort tid, ushort sid)
		{
			ushort p1 = (ushort)(pid >> 16);
			ushort p2 = (ushort)(pid & 0xFFFF);
			return ((tid ^ sid) ^ (p1 ^ p2)) < 8;
		}
	}
}
