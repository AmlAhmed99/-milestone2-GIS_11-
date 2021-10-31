using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
// to deal with map info
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
// to deal with adding new layer
using ESRI.ArcGIS.DataSourcesGDB;
// to check the shape of the feature
using ESRI.ArcGIS.Geometry;

namespace ProjectGIS2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count;
       
        private void Form1_Load(object sender, EventArgs e)
        {
            loadmap.Text = @"C:\Data\Maps\Map1.mxd";
            comboBox1.Items.Add(esriSelectionResultEnum.esriSelectionResultAdd);
            comboBox1.Items.Add(esriSelectionResultEnum.esriSelectionResultSubtract);
            comboBox1.Items.Add(esriSelectionResultEnum.esriSelectionResultNew);

            comboBox2.Items.Add(esriSpatialRelEnum.esriSpatialRelContains);
            comboBox2.Items.Add(esriSpatialRelEnum.esriSpatialRelIntersects);
            comboBox2.Items.Add(esriSpatialRelEnum.esriSpatialRelTouches);
            comboBox2.Items.Add(esriSpatialRelEnum.esriSpatialRelWithin);
            count = 0;
            
        }
        IMapDocument MapDocument;
        private void loadmap_Click(object sender, EventArgs e)
        {
            listmaps.Items.Clear();
            // Create Variable of MapDocumentClass and interface IMapDocument
            MapDocument = new MapDocumentClass();
            // Get map document from path
            MapDocument.Open(loadmap.Text);
            //to open first map
            IMap map = MapDocument.get_Map(0);
            axMapControl1.Map = map;
            IActiveView actv = map as IActiveView;
            axMapControl1.ActiveView.Extent = actv.Extent;
            axMapControl1.Refresh();

            for (int i = 0; i < MapDocument.MapCount; i++)
            {
                listmaps.Items.Add(MapDocument.get_Map(i).Name);
                
            }
        }

        private void loadlayer_Click(object sender, EventArgs e)
        {
            IMap map = MapDocument.get_Map(listmaps.SelectedIndex);
            axMapControl1.Map = map;
            IActiveView actv = map as IActiveView;
            axMapControl1.ActiveView.Extent = actv.Extent;
            axMapControl1.Refresh();

            listlayer.Items.Clear();


            IEnumLayer mapLayers = map.get_Layers();
            //to access specific layer use next pointer
            ILayer layer = mapLayers.Next();
            //loop for all layers 
            while (layer != null)
            {

                listlayer.Items.Add(layer.Name);
                layercmb.Items.Add(layer.Name);
                mapcmb.Items.Add(layer.Name);
                layer.Visible = true;
                layer = mapLayers.Next();

            }
        }
        private IFeatureLayer getLayerByName(string layerName)
        {
            IEnumLayer allLayers;
            allLayers = axMapControl1.ActiveView.FocusMap.get_Layers(null, true);
            ILayer layer = allLayers.Next();
            while (layer != null)
            {
                if (layer.Name == layerName)
                {
                    return ((IFeatureLayer)(layer));
                }
                layer = allLayers.Next();
            }
            return null;

        }
        IFeatureSelection featureSelection1;
        private void attributebtn_Click(object sender, EventArgs e)
        {
            IFeatureLayer SelectedLayer = getLayerByName(listlayer.Text);         
            IFeatureCursor featchCursor;            
            IQueryFilter queryFilter = new QueryFilterClass();            
            queryFilter.WhereClause = textquery.Text;
            featchCursor = SelectedLayer.FeatureClass.Search(queryFilter, true);

            IFeature feature = featchCursor.NextFeature();


            // selecting wanted featuresse

             featureSelection1 = SelectedLayer as IFeatureSelection;
            esriSelectionResultEnum obj = myfun();
            featureSelection1.SelectFeatures(queryFilter, obj, false);
            axMapControl1.Refresh();
            //////display gideview////////////
           
              dataGridView1.ColumnCount = 100;          
              dataGridView1.Columns[count].Name = featlist1.Text;
              int i = 0;
              while (feature != null)
              {

                      
                      dataGridView1.Rows[i].Cells[count].Value = feature.get_Value(featlist1.SelectedIndex).ToString();
                      i++;
                      dataGridView1.Rows.Add();
                      feature = featchCursor.NextFeature();
                     
                   
                 
              }
              
              
             //get count features
            ISelectionSet selectionset = featureSelection1.SelectionSet;
            featurelbl.Text=selectionset.Count.ToString();
            count++;
           

            /////////////////////////////////


        }

       

        esriSelectionResultEnum myfun() {

            if (comboBox1.SelectedItem.Equals(esriSelectionResultEnum.esriSelectionResultNew))
            {
                return esriSelectionResultEnum.esriSelectionResultNew;
            }
            else if (comboBox1.SelectedItem.Equals(esriSelectionResultEnum.esriSelectionResultAdd))
            {
                return esriSelectionResultEnum.esriSelectionResultAdd;
            }
            else if (comboBox1.SelectedItem.Equals(esriSelectionResultEnum.esriSelectionResultSubtract))
            {
                return esriSelectionResultEnum.esriSelectionResultSubtract;
            }
            return esriSelectionResultEnum.esriSelectionResultNew;
        }
        esriSpatialRelEnum myfun2()
        {

            if (comboBox2.SelectedItem.Equals(esriSpatialRelEnum.esriSpatialRelContains))
            {
                return esriSpatialRelEnum.esriSpatialRelContains;
            }
            else if (comboBox2.SelectedItem.Equals(esriSpatialRelEnum.esriSpatialRelIntersects))
            {
                return esriSpatialRelEnum.esriSpatialRelIntersects;
            }
            else if (comboBox2.SelectedItem.Equals(esriSpatialRelEnum.esriSpatialRelWithin))
            {
                return esriSpatialRelEnum.esriSpatialRelWithin;
            }
            return esriSpatialRelEnum.esriSpatialRelContains;
        }



        IFeatureSelection featureSelection;
        private void spatialquery_Click(object sender, EventArgs e)
        {
            IFeatureLayer srcLayer = getLayerByName(layercmb.Text);
            IQueryFilter queryFilter = new QueryFilterClass();
            queryFilter.WhereClause = wheretxt.Text;


            IFeatureCursor featchCursor;
            featchCursor = srcLayer.FeatureClass.Search(queryFilter, true);

            axMapControl1.Refresh();
            /////////////////////////////////////////////////////////////
            // Selectinf feature from target layer 

            IFeature feat = featchCursor.NextFeature();
            ISpatialFilter spatialFilter = new SpatialFilterClass();
            esriSpatialRelEnum obj = myfun2();
            spatialFilter.SpatialRel = obj;

            spatialFilter.Geometry = feat.Shape;


            IFeatureLayer targetLayer = getLayerByName(mapcmb.Text) as IFeatureLayer;

            
            featureSelection = targetLayer as IFeatureSelection;


            featureSelection.SelectFeatures(spatialFilter, esriSelectionResultEnum.esriSelectionResultNew, false);
            feat = featchCursor.NextFeature();

            while (feat != null)
            {
                spatialFilter.Geometry = feat.Shape;
                // add next result to the last to get all features
                featureSelection.SelectFeatures(spatialFilter, esriSelectionResultEnum.esriSelectionResultAdd, false);
                feat = featchCursor.NextFeature();

            }
            axMapControl1.Refresh();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            featlist1.Items.Clear();
            IFeatureLayer SelectedLayer = getLayerByName(listlayer.Text);

            for(int i=0;i<SelectedLayer.FeatureClass.Fields.FieldCount;i++)
            {
                featlist1.Items.Add(SelectedLayer.FeatureClass.Fields.Field[i].Name);
                
            
            }


            
                

            }

        private void button3_Click(object sender, EventArgs e)
        {
            featlist2.Items.Clear();


            IFeatureLayer srcLayer = getLayerByName(listlayer.Text);



            IQueryFilter queryFilter = new QueryFilterClass();
            queryFilter.WhereClause = "";
            IFeatureCursor featchCursor;

            featchCursor = srcLayer.FeatureClass.Search(queryFilter, true);

           
            // Selectinf feature from target layer 

            IFeature feat = featchCursor.NextFeature();
            
            feat = featchCursor.NextFeature();

            ////////////my//////////////////////////////////////
            HashSet<String> values = new HashSet<String>();
            while (feat != null)
            {

                values.Add(feat.get_Value(featlist1.SelectedIndex).ToString());
                feat = featchCursor.NextFeature();
            }

            foreach(String val in values){
            
            featlist2.Items.Add(val);
            }
          
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            featureSelection.Clear();
            featureSelection1.Clear();
            axMapControl1.Refresh();
        }

        private void layercmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            textquery.Text = featlist1.Text + featlist2.Text;
            

        }


        }
    }
