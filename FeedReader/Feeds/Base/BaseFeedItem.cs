﻿namespace CodeHollow.FeedReader.Feeds
{
    using System.Xml.Linq;

    /// <summary>
    /// The base object for all feed items
    /// </summary>
    public abstract class BaseFeedItem
    {
        /// <summary>
        /// The "title" element
        /// </summary>
        public string Title { get; set; } // title

        /// <summary>
        /// The "link" element
        /// </summary>
        public string Link { get; set; } // link

        /// <summary>
        /// Gets the underlying XElement in order to allow reading properties that are not available in the class itself
        /// </summary>
        public XElement Element { get; }

        internal abstract FeedItem ToFeedItem();

        /// <summary>
        /// default constructor (for serialization)
        /// </summary>
        public BaseFeedItem() { }

        /// <summary>
        /// Reads a base feed item based on the xml given in element
        /// </summary>
        /// <param name="item"></param>
        public BaseFeedItem(XElement item)
        {
            this.Title = item.GetValue("title");
            this.Link = item.GetValue("link");
            this.Element = item;
        }
    }
}
