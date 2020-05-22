using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeEnrypt
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      /**
       * This function is called, if the user wants to 
       * select a file by the file explorer.
       */
      private void buttonSelectFile_Click( object sender, EventArgs e )
      {
         OpenFileDialog Dlg = new OpenFileDialog();
         Dlg.Title = "Select File for Crypt/Decrypt";
         if( DialogResult.OK == Dlg.ShowDialog() )
         {
            labelFile.Text = Dlg.FileName;
         }
      }

      /**
       */
      private string Encrypt( string sSrcFile )
      {
         string sDstFile = "";
         //
         if( sSrcFile.EndsWith( ".crypt" ) )                //encrypted file?
         {                                                  // yes, then...
            sDstFile = sSrcFile.Substring( 0, sSrcFile.Length - 6 );
         }
         else
         {
            sDstFile = sSrcFile+".crypt";
         }
         //
         Stream   strDst = File.OpenWrite( sDstFile );
         Stream   strSrc = File.OpenRead( sSrcFile );
         byte[]   abBuffer = new byte[32768];
         int      iBytesRead;
         //
         while( ( iBytesRead = strSrc.Read( abBuffer, 0, abBuffer.Length ) ) > 0 )
         {
            for( int iIdx=0; iIdx<iBytesRead; iIdx++ )
            {
               abBuffer[iIdx] ^= 0xFF;
            }
            strDst.Write( abBuffer, 0, iBytesRead );
         }
         strDst.Close();
         strSrc.Close();
         //
         return sDstFile;
      }


      private void buttonStart_Click( object sender, EventArgs e )
      {
         string sFile = labelFile.Text;
         if ( File.Exists( sFile ) )                        //does file exists?
         {                                                  // yes, then...
            sFile = Encrypt( sFile );                       // run
            MessageBox.Show( "The file '"+sFile+"' was created.",
               "Encrypt/Decrypt Success",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information );
         }
         else                                               //otherwise
         {                                                  // then...
            MessageBox.Show( "The file '"+sFile+"' is not readable!",
               "File Access Error", 
               MessageBoxButtons.OK, 
               MessageBoxIcon.Error );
         }
      }
   }
}
