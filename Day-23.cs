static void levelOrder(Node root){
  		//Write your code here
        var queue = new Queue<Node>();
        queue.Enqueue(root);
        while (queue.Count != 0)
        {
            Node curr = queue.Dequeue();
            Console.Write(curr.data + " ");

            if (curr.left != null) queue.Enqueue(curr.left);
            if (curr.right != null) queue.Enqueue(curr.right);
        }
    }