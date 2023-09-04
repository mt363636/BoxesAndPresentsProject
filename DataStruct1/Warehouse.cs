using DataStruct1.DatabaseLoad;
using DataStruct1.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct1
{
    public class Warehouse //special class that manages the warehouse, i.e updating total quantity of boxes,removing the expired ones
    {
        private static Tree<double, Box> boxTree = new Tree<double, Box>(); 

        public void FillInventory(double baseSize, double height, int quantity, int agingDuration)
        {
            Box newBox = new Box(baseSize, height, quantity, agingDuration);
            boxTree.AddNode(baseSize, newBox);
        }


        public void UpdateQuantity(double baseSize, double height, int newQuantity)
        {
            TreeNode<double, Box> boxNode = boxTree.FindNode(baseSize);
            if (boxNode != null)
            {
                boxNode.Value.Quantity = newQuantity;

                // Remove item if out of stock
                if (newQuantity == 0)
                {
                    boxTree.RemoveNode(boxNode.Key);
                }
            }
        }
       


        public void DisplayBoxInformation(double baseSize, double height)
        {
            TreeNode<double, Box> boxNode = boxTree.FindNode(baseSize);
            if (boxNode != null)
            {
                Console.WriteLine($"Box with Base Size: {boxNode.Key}, Height: {boxNode.Value.Height}, Quantity: {boxNode.Value.Quantity}");
            }
            else
            {
                Console.WriteLine("Box not found.");
            }
        }


        public TreeNode<double, Box> FindSuitableBoxForGift(double giftBaseSize, double giftHeight)
        {
            return boxTree.FindSuitableBoxForGift(giftBaseSize, giftHeight);
        }

        public bool IsExpired(Box box)
        {
            DateTime currentTime = DateTime.Now;
            return box.ExpiryDate <= currentTime;
        }




        public void LoadInventoryFromFile()
        {
            List<Box> boxes = LoadAndSaveData.LoadDataFromFile();
            foreach (Box box in boxes)
            {
                // Add the box to the inventory
                boxTree.AddNode(box.BaseSize, box);
            }
        }

        public void ShowAndDeleteExpiredBoxes(List<Box> existingInventory)
        {
            List<TreeNode<double, Box>> expiredBoxNodes = boxTree.FindExpiredNodes(existingInventory);

            foreach (var expiredBoxNode in expiredBoxNodes)
            {
                if (boxTree.IsExpired(expiredBoxNode.Value))
                {
                    Console.WriteLine($"Expired Box: BaseSize={expiredBoxNode.Key}, Height={expiredBoxNode.Value.Height}");
                    boxTree.RemoveNode(expiredBoxNode.Key);
                    Console.WriteLine($"Deleted Expired Box: BaseSize={expiredBoxNode.Key}");
                }
            }
        }

        public List<Box> GetAvailableBoxes()
        {
            List<Box> availableBoxes = new List<Box>();

            TraverseBoxTree(boxTree.Root, availableBoxes);

            return availableBoxes;
        }
      

        public void SaveInventoryToFile()
        {
            List<Box> inventory = new List<Box>();
            TraverseBoxTree(boxTree.Root, inventory);
            LoadAndSaveData.SaveDataInFile(inventory);
        }


        private void TraverseBoxTree(TreeNode<double, Box> node, List<Box> boxes)
        {
            if (node == null)
            {
                return;
            }

            TraverseBoxTree(node.Left, boxes);

            if (node.Value.Quantity > 0)
            {
                boxes.Add(node.Value);
            }

            TraverseBoxTree(node.Right, boxes);
        }
        public PurchaseBoxResult PurchaseBox(double giftBaseSize, double giftHeight, int quantity)
        {
            TreeNode<double, Box> suitableBoxNode = boxTree.FindSuitableBoxForGift(giftBaseSize, giftHeight);

            if (suitableBoxNode != null)
            {
                Box suitableBox = suitableBoxNode.Value;

                if (suitableBox.Quantity >= quantity)
                {
                    suitableBox.Quantity -= quantity;

                    if (suitableBox.Quantity == 5)
                    {
                        Console.WriteLine("Alert: Quantity limit approaching (5 items left).");
                    }

                    if (suitableBox.Quantity == 0)
                    {
                        boxTree.RemoveNode(suitableBoxNode.Key);
                    }

                    return new PurchaseBoxResult(true, "Purchase successful.")
                    {
                        PurchasedBox = suitableBox
                    };
                }
                else
                {
                    return new PurchaseBoxResult(false, "Alert: Low stock for the selected box.");
                }
            }
            else
            {
                return new PurchaseBoxResult(false, "No suitable box found for the gift.");
            }
        }

    }





}

