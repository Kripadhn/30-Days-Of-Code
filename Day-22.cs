static int getHeight(Node root){
      //Write your code here
      return root == null ? -1 : 1 + Math.Max(getHeight(root.left), getHeight(root.right));
    }