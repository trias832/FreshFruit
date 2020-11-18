using FreshFruit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FreshFruit.Controller
{
    class BucketController
    {
        private Bucket bucket;
        private BucketEvenListener evenListener;
        public BucketController(Bucket bucket, BucketEvenListener evenListener)
        {
            this.bucket = bucket;
            this.evenListener = evenListener;
        }
        public void addFruit(Fruit fruit)
        {
            if (bucketIsOverload())
            {
                evenListener.onFailed("Ops,Keranjang penuh");
            }
            else
            {
                this.bucket.insert(fruit);
                evenListener.onSucceed("Yeay, berhasil ditambahkan");
            }
        }
        public bool bucketIsOverload()
        {
            return bucket.countItems() >= bucket.getCapacity();
        }
        public void removeFruit(Fruit fruit)
        {
            for (int itemPosition =0; itemPosition < bucket.countItems(); itemPosition++)
            {
                if (bucket.findAll().ElementAt(itemPosition).getName() == fruit.getName())
                {
                    bucket.remove(itemPosition);
                    evenListener.onSucceed("Yry, berhasil di hapus");
                }
            }
        }
        public List<Fruit> findAll()
        {
            return this.bucket.findAll();
        }
    }
}
