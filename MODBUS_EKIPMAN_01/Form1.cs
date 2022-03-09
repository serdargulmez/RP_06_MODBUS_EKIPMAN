using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;

namespace MODBUS_EKIPMAN_01
{
    public partial class Form1 : Form
    {
        EasyModbus.ModbusServer mServer;
        EasyModbus.ModbusClient mClient;

        byte watchDog;
        int mtbvar01, mtbvar02, mtbvar03, mtbvar04, mtbvar05, mtbvar06, 
            mtbvar07, mtbvar08, mtbvar09, mtbvar10, mtbvar11, mtbvar12, mtbvar13;

        int mtbivar01, mtbivar02, mtbivar03, mtbivar04, mtbivar05, mtbivar06,
            mtbivar07, mtbivar08, mtbivar09, mtbivar10, mtbivar11, mtbivar12, mtbivar13;

        int mtbohvar01, mtbohvar02, mtbohvar03, mtbohvar04, mtbohvar05, mtbohvar06,
            mtbohvar07, mtbohvar08, mtbohvar09, mtbohvar10, mtbohvar11, mtbohvar12, mtbohvar13;

        int mtbihvar01, mtbihvar02, mtbihvar03, mtbihvar04, mtbihvar05, mtbihvar06,
            mtbihvar07, mtbihvar08, mtbihvar09, mtbihvar10, mtbihvar11, mtbihvar12, mtbihvar13;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            mServer = new EasyModbus.ModbusServer();
            mServer.Listen();

            mClient = new EasyModbus.ModbusClient("127.0.0.1", 502);
            mClient.Connect();

            DI_cb01.Checked = false;
            DO_cb01.Checked = false;

            timer1.Interval = 1000;
            timer1.Enabled = true;
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            if (watchDog == 11)
            {
                watchDog = 1;
            }

            watch.Text = Convert.ToString(watchDog);

            mClient.WriteSingleRegister(1, watchDog);

            watchDog++;

            bool[] varBOOLs01 = mClient.ReadCoils(mtbivar01, 1);
            bool[] varBOOLs02 = mClient.ReadCoils(mtbivar02, 1);
            bool[] varBOOLs03 = mClient.ReadCoils(mtbivar03, 1);
            bool[] varBOOLs04 = mClient.ReadCoils(mtbivar04, 1);
            bool[] varBOOLs05 = mClient.ReadCoils(mtbivar05, 1);
            bool[] varBOOLs06 = mClient.ReadCoils(mtbivar06, 1);
            bool[] varBOOLs07 = mClient.ReadCoils(mtbivar07, 1);
            bool[] varBOOLs08 = mClient.ReadCoils(mtbivar08, 1);
            bool[] varBOOLs09 = mClient.ReadCoils(mtbivar09, 1);
            bool[] varBOOLs10 = mClient.ReadCoils(mtbivar10, 1);
            bool[] varBOOLs11 = mClient.ReadCoils(mtbivar11, 1);
            bool[] varBOOLs12 = mClient.ReadCoils(mtbivar12, 1);
            bool[] varBOOLs13 = mClient.ReadCoils(mtbivar13, 1);

            if (varBOOLs01[0] == true) { DI_cb01.Checked = true; } else { DI_cb01.Checked = false; }
            if (varBOOLs02[0] == true) { DI_cb02.Checked = true; } else { DI_cb02.Checked = false; }
            if (varBOOLs03[0] == true) { DI_cb03.Checked = true; } else { DI_cb03.Checked = false; }
            if (varBOOLs04[0] == true) { DI_cb04.Checked = true; } else { DI_cb04.Checked = false; }
            if (varBOOLs05[0] == true) { DI_cb05.Checked = true; } else { DI_cb05.Checked = false; }
            if (varBOOLs06[0] == true) { DI_cb06.Checked = true; } else { DI_cb06.Checked = false; }
            if (varBOOLs07[0] == true) { DI_cb07.Checked = true; } else { DI_cb07.Checked = false; }
            if (varBOOLs08[0] == true) { DI_cb08.Checked = true; } else { DI_cb08.Checked = false; }
            if (varBOOLs09[0] == true) { DI_cb09.Checked = true; } else { DI_cb09.Checked = false; }
            if (varBOOLs10[0] == true) { DI_cb10.Checked = true; } else { DI_cb10.Checked = false; }
            if (varBOOLs11[0] == true) { DI_cb11.Checked = true; } else { DI_cb11.Checked = false; }
            if (varBOOLs12[0] == true) { DI_cb12.Checked = true; } else { DI_cb12.Checked = false; }
            if (varBOOLs13[0] == true) { DI_cb13.Checked = true; } else { DI_cb13.Checked = false; }


            int[] varHold01 = mClient.ReadHoldingRegisters(mtbihvar01, 1);
            int[] varHold02 = mClient.ReadHoldingRegisters(mtbihvar02, 1);
            int[] varHold03 = mClient.ReadHoldingRegisters(mtbihvar03, 1);
            int[] varHold04 = mClient.ReadHoldingRegisters(mtbihvar04, 1);
            int[] varHold05 = mClient.ReadHoldingRegisters(mtbihvar05, 1);
            int[] varHold06 = mClient.ReadHoldingRegisters(mtbihvar06, 1);
            int[] varHold07 = mClient.ReadHoldingRegisters(mtbihvar07, 1);
            int[] varHold08 = mClient.ReadHoldingRegisters(mtbihvar08, 1);
            int[] varHold09 = mClient.ReadHoldingRegisters(mtbihvar09, 1);
            int[] varHold10 = mClient.ReadHoldingRegisters(mtbihvar10, 1);
            int[] varHold11 = mClient.ReadHoldingRegisters(mtbihvar11, 1);
            int[] varHold12 = mClient.ReadHoldingRegisters(mtbihvar12, 1);
            int[] varHold13 = mClient.ReadHoldingRegisters(mtbihvar13, 1);

            mtbihi_01.Text = Convert.ToString(varHold01[0]);
            mtbihi_02.Text = Convert.ToString(varHold02[0]);
            mtbihi_03.Text = Convert.ToString(varHold03[0]);
            mtbihi_04.Text = Convert.ToString(varHold04[0]);
            mtbihi_05.Text = Convert.ToString(varHold05[0]);
            mtbihi_06.Text = Convert.ToString(varHold06[0]);
            mtbihi_07.Text = Convert.ToString(varHold07[0]);
            mtbihi_08.Text = Convert.ToString(varHold08[0]);
            mtbihi_09.Text = Convert.ToString(varHold09[0]);
            mtbihi_10.Text = Convert.ToString(varHold10[0]);
            mtbihi_11.Text = Convert.ToString(varHold11[0]);
            mtbihi_12.Text = Convert.ToString(varHold12[0]);
            mtbihi_13.Text = Convert.ToString(varHold13[0]);







            timer1.Enabled = true;

        }

        private void DO_cb01_CheckedChanged(object sender, EventArgs e)
        {
            if (DO_cb01.Checked == true) { mClient.WriteSingleCoil(mtbvar01, true); } else { mClient.WriteSingleCoil(mtbvar01, false); }
        }

        private void DO_cb02_CheckedChanged(object sender, EventArgs e)
        {
            if (DO_cb02.Checked == true) { mClient.WriteSingleCoil(mtbvar02, true); } else { mClient.WriteSingleCoil(mtbvar02, false); }
        }

        private void DO_cb03_CheckedChanged(object sender, EventArgs e)
        {
            if (DO_cb03.Checked == true) { mClient.WriteSingleCoil(mtbvar03, true); } else { mClient.WriteSingleCoil(mtbvar03, false); }
        }

        private void DO_cb04_CheckedChanged(object sender, EventArgs e)
        {
            if (DO_cb04.Checked == true) { mClient.WriteSingleCoil(mtbvar04, true); } else { mClient.WriteSingleCoil(mtbvar04, false); }
        }

        private void DO_cb05_CheckedChanged(object sender, EventArgs e)
        {
            if (DO_cb05.Checked == true) { mClient.WriteSingleCoil(mtbvar05, true); } else { mClient.WriteSingleCoil(mtbvar05, false); }
        }

        private void DO_cb06_CheckedChanged(object sender, EventArgs e)
        {
            if (DO_cb06.Checked == true) { mClient.WriteSingleCoil(mtbvar06, true); } else { mClient.WriteSingleCoil(mtbvar06, false); }
        }

        private void DO_cb07_CheckedChanged(object sender, EventArgs e)
        {
            if (DO_cb07.Checked == true) { mClient.WriteSingleCoil(mtbvar07, true); } else { mClient.WriteSingleCoil(mtbvar07, false); }
        }

        private void DO_cb08_CheckedChanged(object sender, EventArgs e)
        {
            if (DO_cb08.Checked == true) { mClient.WriteSingleCoil(mtbvar08, true); } else { mClient.WriteSingleCoil(mtbvar08, false); }
        }

        private void DO_cb09_CheckedChanged(object sender, EventArgs e)
        {
            if (DO_cb09.Checked == true) { mClient.WriteSingleCoil(mtbvar09, true); } else { mClient.WriteSingleCoil(mtbvar09, false); }
        }

        private void DO_cb10_CheckedChanged(object sender, EventArgs e)
        {
            if (DO_cb10.Checked == true) { mClient.WriteSingleCoil(mtbvar10, true); } else { mClient.WriteSingleCoil(mtbvar10, false); }
        }

        private void DO_cb11_CheckedChanged(object sender, EventArgs e)
        {
            if (DO_cb11.Checked == true) { mClient.WriteSingleCoil(mtbvar11, true); } else { mClient.WriteSingleCoil(mtbvar11, false); }
        }

        private void DO_cb12_CheckedChanged(object sender, EventArgs e)
        {
            if (DO_cb12.Checked == true) { mClient.WriteSingleCoil(mtbvar12, true); } else { mClient.WriteSingleCoil(mtbvar12, false); }
        }

        private void DO_cb13_CheckedChanged(object sender, EventArgs e)
        {
            if (DO_cb13.Checked == true) { mClient.WriteSingleCoil(mtbvar13, true); } else { mClient.WriteSingleCoil(mtbvar13, false); }
        }

        private void mtboho_01_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtboho_01.Text;
            

            if (var01 == "" | var01 == "") { return; }
            else
            {
                int var02 = Convert.ToInt32(var01);
                mClient.WriteSingleRegister(mtbohvar01,var02);
            }

        }

        private void mtboho_02_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtboho_02.Text;


            if (var01 == "" | var01 == "") { return; }
            else
            {
                int var02 = Convert.ToInt32(var01);
                mClient.WriteSingleRegister(mtbohvar02, var02);
            }

        }

        private void mtboho_03_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtboho_03.Text;


            if (var01 == "" | var01 == "") { return; }
            else
            {
                int var02 = Convert.ToInt32(var01);
                mClient.WriteSingleRegister(mtbohvar03, var02);
            }

        }

        private void mtboho_04_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtboho_04.Text;


            if (var01 == "" | var01 == "") { return; }
            else
            {
                int var02 = Convert.ToInt32(var01);
                mClient.WriteSingleRegister(mtbohvar04, var02);
            }

        }

        private void mtboho_05_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtboho_05.Text;


            if (var01 == "" | var01 == "") { return; }
            else
            {
                int var02 = Convert.ToInt32(var01);
                mClient.WriteSingleRegister(mtbohvar05, var02);
            }

        }

        private void mtboho_06_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtboho_06.Text;


            if (var01 == "" | var01 == "") { return; }
            else
            {
                int var02 = Convert.ToInt32(var01);
                mClient.WriteSingleRegister(mtbohvar06, var02);
            }

        }

        private void mtboho_07_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtboho_07.Text;


            if (var01 == "" | var01 == "") { return; }
            else
            {
                int var02 = Convert.ToInt32(var01);
                mClient.WriteSingleRegister(mtbohvar07, var02);
            }

        }

        private void mtboho_08_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtboho_08.Text;


            if (var01 == "" | var01 == "") { return; }
            else
            {
                int var02 = Convert.ToInt32(var01);
                mClient.WriteSingleRegister(mtbohvar08, var02);
            }

        }

        private void mtboho_09_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtboho_09.Text;


            if (var01 == "" | var01 == "") { return; }
            else
            {
                int var02 = Convert.ToInt32(var01);
                mClient.WriteSingleRegister(mtbohvar09, var02);
            }

        }

        private void mtboho_10_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtboho_10.Text;


            if (var01 == "" | var01 == "") { return; }
            else
            {
                int var02 = Convert.ToInt32(var01);
                mClient.WriteSingleRegister(mtbohvar10, var02);
            }

        }

        private void mtboho_11_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtboho_11.Text;


            if (var01 == "" | var01 == "") { return; }
            else
            {
                int var02 = Convert.ToInt32(var01);
                mClient.WriteSingleRegister(mtbohvar11, var02);
            }

        }

        private void mtboho_12_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtboho_12.Text;


            if (var01 == "" | var01 == "") { return; }
            else
            {
                int var02 = Convert.ToInt32(var01);
                mClient.WriteSingleRegister(mtbohvar12, var02);
            }

        }

        private void mtboho_13_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtboho_13.Text;


            if (var01 == "" | var01 == "") { return; }
            else
            {
                int var02 = Convert.ToInt32(var01);
                mClient.WriteSingleRegister(mtbohvar13, var02);
            }

        }





        

        private void mtb_01_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtb_01.Text;
            if(var01 == "" | var01 == "") { return; }
            else
            {
                mtbvar01 = Convert.ToInt32(var01);

            }
        }

        private void mtb_02_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtb_02.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbvar02 = Convert.ToInt32(var01);

            }
        }

        private void mtb_03_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtb_03.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbvar03 = Convert.ToInt32(var01);

            }
        }

        private void mtb_04_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtb_04.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbvar04 = Convert.ToInt32(var01);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void mtb_05_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtb_05.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbvar05 = Convert.ToInt32(var01);

            }
        }

        private void mtb_06_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtb_06.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbvar06 = Convert.ToInt32(var01);

            }
        }

        private void mtb_07_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtb_07.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbvar07 = Convert.ToInt32(var01);

            }
        }

        private void mtb_08_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtb_08.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbvar08 = Convert.ToInt32(var01);

            }
        }

        private void mtb_09_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtb_09.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbvar09 = Convert.ToInt32(var01);

            }
        }

        private void mtb_10_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtb_10.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbvar10 = Convert.ToInt32(var01);

            }
        }

        private void mtb_11_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtb_11.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbvar11 = Convert.ToInt32(var01);

            }
        }

        private void mtb_12_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtb_12.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbvar12 = Convert.ToInt32(var01);

            }
        }

        private void mtb_13_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtb_13.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbvar13 = Convert.ToInt32(var01);

            }
        }

        private void mtbi_01_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtbi_01.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbivar01 = Convert.ToInt32(var01);

            }
        }

        private void mtbi_02_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtbi_02.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbivar02 = Convert.ToInt32(var01);

            }
        }

        private void mtbi_03_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtbi_03.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbivar03 = Convert.ToInt32(var01);

            }
        }

        private void mtbi_04_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtbi_04.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbivar04 = Convert.ToInt32(var01);

            }
        }

        private void mtbi_05_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtbi_05.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbivar05 = Convert.ToInt32(var01);

            }
        }

        private void mtbi_06_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtbi_06.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbivar06 = Convert.ToInt32(var01);

            }
        }

        private void mtbi_07_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtbi_07.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbivar07 = Convert.ToInt32(var01);

            }
        }

        private void mtbi_08_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtbi_08.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbivar08 = Convert.ToInt32(var01);

            }
        }

        private void mtbi_09_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtbi_09.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbivar09 = Convert.ToInt32(var01);

            }
        }

        private void mtbi_10_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtbi_10.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbivar10 = Convert.ToInt32(var01);

            }
        }

        private void mtbi_11_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtbi_11.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbivar11 = Convert.ToInt32(var01);

            }
        }

        private void mtbi_12_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtbi_12.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbivar12 = Convert.ToInt32(var01);

            }
        }

        private void mtbi_13_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtbi_13.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbivar13 = Convert.ToInt32(var01);

            }
        }

        private void mtboh_01_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtboh_01.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbohvar01 = Convert.ToInt32(var01);

            }
        }

        private void mtboh_02_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtboh_02.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbohvar02 = Convert.ToInt32(var01);

            }
        }

        private void mtboh_03_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtboh_03.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbohvar03 = Convert.ToInt32(var01);

            }
        }

        private void mtboh_04_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtboh_04.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbohvar04 = Convert.ToInt32(var01);

            }
        }

        private void mtboh_05_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtboh_05.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbohvar05 = Convert.ToInt32(var01);

            }
        }

        private void mtboh_06_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtboh_06.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbohvar06 = Convert.ToInt32(var01);

            }
        }

        private void mtboh_07_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtboh_07.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbohvar07 = Convert.ToInt32(var01);

            }
        }

        private void mtboh_08_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtboh_08.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbohvar08 = Convert.ToInt32(var01);

            }
        }

        private void mtboh_09_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtboh_09.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbohvar09 = Convert.ToInt32(var01);

            }
        }

        private void mtboh_10_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtboh_10.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbohvar10 = Convert.ToInt32(var01);

            }
        }

        private void mtboh_11_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtboh_11.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbohvar11 = Convert.ToInt32(var01);

            }
        }

        private void mtboh_12_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtboh_12.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbohvar12 = Convert.ToInt32(var01);

            }
        }

        private void mtboh_13_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtboh_13.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbohvar13 = Convert.ToInt32(var01);

            }
        }

        private void mtbih_01_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtbih_01.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbihvar01 = Convert.ToInt32(var01);

            }
        }

        private void mtbih_02_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtbih_02.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbihvar02 = Convert.ToInt32(var01);

            }
        }

        private void mtbih_03_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtbih_03.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbihvar03 = Convert.ToInt32(var01);

            }
        }

        private void mtbih_04_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtbih_04.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbihvar04 = Convert.ToInt32(var01);

            }
        }

        private void mtbih_05_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtbih_05.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbihvar05 = Convert.ToInt32(var01);

            }
        }

        private void mtbih_06_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtbih_06.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbihvar06 = Convert.ToInt32(var01);

            }
        }

        private void mtbih_07_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtbih_07.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbihvar07 = Convert.ToInt32(var01);

            }
        }

        private void mtbih_08_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtbih_08.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbihvar08 = Convert.ToInt32(var01);

            }
        }

        private void mtbih_09_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtbih_09.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbihvar09 = Convert.ToInt32(var01);

            }
        }

        private void mtbih_10_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtbih_10.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbihvar10 = Convert.ToInt32(var01);

            }
        }

        private void mtbih_11_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtbih_11.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbihvar11 = Convert.ToInt32(var01);

            }
        }

        private void mtbih_12_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtbih_12.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbihvar12 = Convert.ToInt32(var01);

            }
        }

        private void mtbih_13_TextChanged(object sender, EventArgs e)
        {
            string var01 = mtbih_13.Text;
            if (var01 == "" | var01 == "") { return; }
            else
            {
                mtbihvar13 = Convert.ToInt32(var01);

            }
        }
    }
}
