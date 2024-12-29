using System;
using System.Collections.Generic;

namespace SingleList{
    public class Node<T>{
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node(T data){
            Data = data;
            Next = null;
        }
    }
    public class SingleList<T>{
        private Node<T> head;
        private int count;
        public SingleList(){
            head = null;
            count = 0;
        }
        public void Add(T data){
            Node<T> newNode = new Node<T>(data);
            if (head == null){
                head = newNode;
            }
            else{
                Node<T> current = head;
                while (current.Next != null){
                    current = current.Next;
                }
                current.Next = newNode;
            }
            count++;
        }
        public bool Remove(T data){
            if (head == null){
                return false;
            }
            if (head.Data.Equals(data)){
                head = head.Next;
                count--;
                return true;
            }
            Node<T> current = head;
            while (current.Next != null && !current.Next.Data.Equals(data)){
                current = current.Next;
            }
            if (current.Next == null){
                return false;
            }
            current.Next = current.Next.Next;
            count--;
            return true;
        }
        public T GetIndex(int index){
            if (index < 0 || index >= count){
                throw new ArgumentOutOfRangeException("Індекса не існує");
            }
            Node<T> current = head;
            for (int i = 0; i < index; i++){
                current = current.Next;
            }
            return current.Data;
        }
        public bool Exist(T data){
            Node<T> current = head;
            while (current != null){
                if (current.Data.Equals(data)){
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        public int Count{
            get{
                return count;
            }
        }
        public void Print(){
            Node<T> current = head;
            Console.Write("Список: ");
            while (current != null){
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
        public void Reverse(){
            Node<T> prev = null; Node<T> current = head; Node<T> next = null; while (current != null){
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            head = prev;
        }
    }
}